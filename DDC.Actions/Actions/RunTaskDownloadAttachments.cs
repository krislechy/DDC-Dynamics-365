using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yolva.DDC.Plugins.BL;

namespace Yolva.DDC.Plugins.Actions
{
    public class RunTaskDownloadAttachments : InjectionBasePlugin
    {
        public override void Execute(PluginState pluginState)
        {
            var ge = (string)pluginState.Context.InputParameters["ge"];
            var tda = new TaskDownloadAttachments();
            var result = tda.Start(DateTime.Parse(ge)).GetAwaiter().GetResult();
            pluginState.Context.OutputParameters["IsSuccess"] = result.IsSuccess;
            pluginState.Context.OutputParameters["Message"] = result.Message;
        }
    }
}
