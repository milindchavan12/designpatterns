using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class WindowDownCommand : IVoiceCommand
    {
        private ElectricWindow window;

        public WindowDownCommand(ElectricWindow window)
        {
            this.window = window;
        }

        public void Execute()
        {
            window.OpenWindow();
        }
    }
}
