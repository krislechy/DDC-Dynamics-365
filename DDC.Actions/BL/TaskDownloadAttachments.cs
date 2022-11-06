using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Yolva.DDC.Plugins.BL
{
    public class ResultAction
    {
        public ResultAction(bool? isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public bool? IsSuccess { get; set; }
        public string Message { get; set; }
    }
    public class TaskDownloadAttachments
    {
        private readonly HttpClient client;
        #if DEBUG
            private const string root = "https://ws19-crm.verticali.ru";
#else
            private const string root = "https://ws19-crm.verticali.ru";
#endif
        private const string url = root+"/api/crm/DownloadAttachments?ge=";
        private const int MaxTimeoutms = 100000;
        public TaskDownloadAttachments()
        {
            client = new HttpClient()
            {
                Timeout=TimeSpan.FromMinutes(3),
            };
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private Task<T> GetResultFactory<T>(Func<Task<T>> action)
        {
            List<Task> tasks = new List<Task>();
            tasks.Add(Task.Delay(MaxTimeoutms));
            tasks.Add(action?.Invoke());
            var completed = Task.WaitAny(tasks.ToArray());
            return tasks.ElementAt(completed) as Task<T>;
        }
        public async Task<ResultAction> Start(DateTime ge)
        {
            try
            {
                var dtFormat = $"{ge.Month}.{ge.Day}.{ge.Year}";
                var get = GetResultFactory(() => client.GetAsync(url + dtFormat));

                if (get == null)
                    return new ResultAction(null, $"Истекло время ожидания выполнения задачи ({TimeSpan.FromMilliseconds(MaxTimeoutms).TotalSeconds} сек.)");
                else
                {
                    if (get.Result.IsSuccessStatusCode)
                    {
                        var content = await get.Result.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<ResultAction>(content);
                        if (result != null)
                            return result;
                        else return new ResultAction(false, content);
                    }
                }
                return new ResultAction(get.Result.IsSuccessStatusCode, get.Result.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.ToString());
            }
        }
    }
}
