using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.PowerPlatform.Dataverse.Client;
using System.Reflection;
using MediatR;
using DDC.BL;
using DDC.DAL;
using NLog;

namespace DDC.WebService
{
    public class StartHost
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartConfig>();
                    //.UseKestrel(o => { o.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(60); });
                });
    }

    public class StartConfig
    {
        public readonly IConfiguration Configuration;
        public StartConfig(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(x => Configuration);
            #region Auth
            var crmSectionConfig = Configuration.GetSection("CRM");
            var url = crmSectionConfig.GetValue<string>("Url");
            var login = crmSectionConfig.GetValue<string>("Login");
            var password = crmSectionConfig.GetValue<string>("Password");

            var auth = new DDC.BL.Services.Auth(url, login, password);
            #endregion
            services.AddScoped<IOrganizationServiceAsync>(x => auth.GetService() as IOrganizationServiceAsync);
            services.AddMediatR(Assembly.GetExecutingAssembly(), Assembly.Load("DDC.BL"));
            #region Logger
            var logger = LogManager.GetCurrentClassLogger();
            services.AddScoped<NLog.ILogger>(x => logger);
            #endregion
            #region Services
            services.AddScoped<IYlvOrgDocumentsService, YlvOrgDocumentsService>();
            services.AddScoped<IAnnotationService, AnnotationService>();
            #endregion
            #region Repositories
            services.AddScoped<IYlvOrgDocumentsRepository, YlvOrgDocumentsRepository>();
            services.AddScoped<IAnnotationRepository, AnnotationRepository>();
            #endregion
            //https://rtowers.crm4.dynamics.com/
            services.AddCors(o => o.AddPolicy("AllowAllPolicy", builder =>
            {
                builder
                .WithOrigins(
                "https://rtowers.crm4.dynamics.com",
                "https://rtowerstest.crm4.dynamics.com",
                "https://localhost:44372"
                )
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
            }));
            services.AddMvcCore();
            services.AddControllers();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseCors();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
