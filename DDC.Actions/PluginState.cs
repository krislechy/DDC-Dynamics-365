using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolva.DDC.Plugins
{
    public class PluginState
    {
        private IOrganizationService service;
        private IPluginExecutionContext context;
        private ITracingService trace;
        private readonly IServiceProvider provider;

        public PluginState(IServiceProvider provider)
        {
            this.provider = provider;
        }
        public virtual IOrganizationService Service
        {
            get
            {
                if (service == null)
                {
                    IOrganizationServiceFactory factory =
                        (IOrganizationServiceFactory)provider.GetService(typeof(IOrganizationServiceFactory));

                    service = factory.CreateOrganizationService(this.Context.UserId);
                }

                return service;
            }
        }
        public virtual IPluginExecutionContext Context
        {
            get
            {
                if (context == null)
                {
                    context = (IPluginExecutionContext)provider.GetService(typeof(IPluginExecutionContext));
                }
                return context;
            }
        }
        public virtual ITracingService TraceService
        {
            get
            {
                if (trace == null)
                {
                    trace = (ITracingService)provider.GetService(typeof(ITracingService));
                }
                return trace;
            }
        }
    }
}
