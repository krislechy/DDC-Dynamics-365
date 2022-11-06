using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Commands
{
    public struct IMainCommand:IRequest
    {
        public string[] Args { get; }

        public IMainCommand(string[] args)
        {
            Args = args;
        }
    }
}
