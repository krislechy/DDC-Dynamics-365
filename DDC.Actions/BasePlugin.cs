using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolva.DDC.Plugins
{
    public abstract class BasePlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            PluginState pluginState = new PluginState(serviceProvider);
            try
            {
                ExecuteInternal(pluginState);
            }
            catch(Exception ex)
            {
                throw new InvalidPluginExecutionException(ex.ToString());
            }
        }
        public abstract void ExecuteInternal(PluginState pluginState);
    }
}
