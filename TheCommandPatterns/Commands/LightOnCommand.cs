using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCommandPatterns.Props;

namespace TheCommandPatterns.Commands
{
    public class LightOnCommand : ICommand
    {
        Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
