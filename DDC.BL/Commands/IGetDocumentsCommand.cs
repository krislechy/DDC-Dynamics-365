using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Commands
{
    public struct IGetDocumentsCommand : IRequest<ResultAction>
    {
        public string[]? Args { get; set; }
    }
}
