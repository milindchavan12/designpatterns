using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class VolumeDownCommand : IVoiceCommand
    {
        private Radio radio;

        public VolumeDownCommand(Radio radio)
        {
            this.radio = radio;
        }

        public void Execute()
        {
            radio.VolumeDown();
        }
    }
}
