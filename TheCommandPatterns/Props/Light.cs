using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCommandPatterns.Props
{
    public class Light : IProp
    {
        private bool _isActive;

        public delegate void State(bool state);
        public State onActiveChanged;

        public Light()
        {
            _isActive = false;
        }

        public void Off()
        {
            _isActive = false;

            onActiveChanged?.Invoke(_isActive);
        }

        public void On()
        {
            _isActive = true;

            onActiveChanged?.Invoke(_isActive);
        }
    }
}
