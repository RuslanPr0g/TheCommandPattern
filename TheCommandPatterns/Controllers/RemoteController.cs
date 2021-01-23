using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCommandPatterns.Commands;

namespace TheCommandPatterns.Controllers
{
    public class RemoteController
    {
        ICommand command;

        public RemoteController()
        {
        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void Execute()
        {
            command.Execute();
        }
    }
}
