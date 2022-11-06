using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Commands
{
    public class MainCommandHandler : AsyncRequestHandler<IMainCommand>
    {
        private readonly IMediator mediator;
        public MainCommandHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        protected async override Task Handle(IMainCommand request, CancellationToken cancellationToken)
        {
            await mediator.Send(new IGetDocumentsCommand() { Args = request.Args });
        }
    }
}
