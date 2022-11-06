using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolva.DDC.Plugins
{
    public abstract class InjectionBasePlugin : BasePlugin
    {
        public sealed override void ExecuteInternal(PluginState pluginState)
        {
            Execute(pluginState);
        }
        public abstract void Execute(PluginState pluginState);
    }
}
