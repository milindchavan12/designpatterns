using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class Radio
    {
        public const int MinValue = 0;
        public const int MaxValue = 10;
        public const int DefaultVolume = 5;

        private bool switchedOn;
        private int volume;

        public Radio()
        {
            switchedOn = false;
            volume = DefaultVolume;
        }

        public virtual bool On
        {
            get
            {
                return switchedOn;
            }
        }

        public virtual int Volume
        {
            get
            {
                return volume;
            }
        }

        public virtual void SwitchOn()
        {
            switchedOn = true;
            Console.WriteLine("Radio is now On, Volume level" + Volume);
        }

        public virtual void SwitchOff()
        {
            switchedOn = false;
            Console.WriteLine("Radio is now Off");
        }

        public virtual void VolumeUp()
        {
            if (On)
            {
                if (Volume < MaxValue)
                {
                    volume++;
                    Console.WriteLine("Volume level turned up to " + Volume);
                }
            }
        }

        public virtual void VolumeDown()
        {
            if (On)
            {
                if (Volume > MaxValue)
                {
                    volume--;
                    Console.WriteLine("Volume level turned down to " + Volume);
                }
            }
        }
    }
}
