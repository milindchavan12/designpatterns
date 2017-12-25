using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class SpeachRecogniser
    {
        private IVoiceCommand upCommand, downCommand;

        public virtual void SetCommands(IVoiceCommand upCommand, IVoiceCommand downCommand)
        {
            this.upCommand = upCommand;
            this.downCommand = downCommand;
        }

        public virtual void HearUpSproken()
        {
            upCommand.Execute();
        }

        public virtual void HearDownSproken()
        {
            downCommand.Execute();
        }
    }
}
