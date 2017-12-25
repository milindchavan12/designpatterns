using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class WindowUpCommand : IVoiceCommand
    {
        private ElectricWindow window;

        public WindowUpCommand(ElectricWindow window)
        {
            this.window = window;
        }

        public void Execute()
        {
            window.CloseWindow();
        }
    }
}
