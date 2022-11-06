using Autofac;
using Autofac.Configuration;
using DDC.BL;
using DDC.DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;
using MediatR.Extensions.Autofac.DependencyInjection;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DDC.Console
{
    public class Container
    {
        public IContainer GetContainer()
        {
            var builder = new ContainerBuilder();
            #region Mediator
            builder.RegisterMediatR(Assembly.GetExecutingAssembly(), Assembly.Load("DDC.BL"));
            #endregion
            #region Logger
            var logger = LogManager.GetCurrentClassLogger();
            builder.Register<ILogger>(x => logger);
            #endregion
            #region RegConfig
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");
            var module = new ConfigurationModule(config.Build());
            builder.RegisterModule(module);
            builder.Register<IConfiguration>(e => module.Configuration);
            #endregion
            #region Auth
            var crmSectionConfig = module.Configuration.GetSection("CRM");
            var url = crmSectionConfig.GetValue<string>("Url");
            var login = crmSectionConfig.GetValue<string>("Login");
            var password = crmSectionConfig.GetValue<string>("Password");

            var auth = new DDC.BL.Services.Auth(url, login, password);
            //ServiceClient service = default!;

            builder.Register((e) =>
            {
                var service=auth.GetService();
                return service as IOrganizationServiceAsync;
            }).As<IOrganizationServiceAsync>();
            #endregion
            #region Repositories
            builder.Register<IYlvOrgDocumentsRepository>(c => new YlvOrgDocumentsRepository(c.Resolve<IOrganizationServiceAsync>()));
            builder.Register<IAnnotationRepository>(c => new AnnotationRepository(c.Resolve<IOrganizationServiceAsync>()));
            #endregion
            #region Services
            builder.RegisterType<YlvOrgDocumentsService>().AsImplementedInterfaces();
            builder.RegisterType<AnnotationService>().AsImplementedInterfaces();
            #endregion

            var container = builder.Build();
            var log = container.Resolve<ILogger>();
            //log.Info($"Connected to: {service.ConnectedOrgFriendlyName}");
            return container;
        }
    }
}
