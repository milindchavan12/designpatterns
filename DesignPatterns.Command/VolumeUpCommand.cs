﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class VolumeUpCommand : IVoiceCommand
    {
        private Radio radio;

        public VolumeUpCommand(Radio radio)
        {
            this.radio = radio;
        }

        public virtual void Execute()
        {
            radio.VolumeUp();
        }
    }
}
