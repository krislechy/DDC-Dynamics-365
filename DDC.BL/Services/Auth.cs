using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Services
{
    public interface IAuth
    {
        public ServiceClient GetService();
    }
    public class Auth:IAuth
    {
        private string url { get; set; }
        private string login { get; set; }
        private string password { get; set; }

        private string connectionString = $@"
            Url = @url;
            AuthType = OAuth;
            UserName = @login;
            Password = @password;
            AppId = 51f81489-12ee-4a9e-aaae-a2591f45987d;
            RedirectUri = app://58145B91-0C36-4500-8554-080854F2AC97;
            LoginPrompt=Never;
            RequireNewInstance = False
            TokenCacheStorePath={AppDomain.CurrentDomain.BaseDirectory}";

        public Auth(string url,string login,string password)
        {
            this.url = url;
            this.login = login;
            this.password = password;
        }
        public ServiceClient GetService()
        {
            var cs=connectionString
                .Replace("@url", url)
                .Replace("@login", login)
                .Replace("@password", password);
            var service = new ServiceClient(cs)
            {
                UseWebApi = true,
            };
            service.MaxRetryCount = 10;
            service.RetryPauseTime=TimeSpan.FromSeconds(30);
            return service;
        }
    }
}
