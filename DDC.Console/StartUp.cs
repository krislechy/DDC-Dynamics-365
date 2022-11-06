using Autofac;
using Autofac.Configuration;
using DDC.BL;
using DDC.BL.Commands;
using DDC.DAL;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;
using NLog;
using System.Text;

namespace DDC.Console
{
    public class StartUp
    {
        private static void Main(params string[] args)
        {
            var mediator = new Container()
                .GetContainer()
                .Resolve<IMediator>();
            mediator.Send(new IMainCommand(args))
                .Wait();

//#if DEBUG
//            System.Console.ReadKey();
//#endif
        }
    }
}