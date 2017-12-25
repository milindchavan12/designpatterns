using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Ignition
    {
        private EngineManagementSystem mediator;
        private bool on;

        public Ignition(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            on = false;

            mediator.RegisterIgnition(this);
        }

        public virtual void Start()
        {
            on = true;
            mediator.IngitionTurnedOn();

            Console.WriteLine("Ignition turned on");
        }

        public virtual void Stop()
        {
            on = false;
            mediator.IngitionTurnedOff();

            Console.WriteLine("Ignition turned off");
        }

        public virtual bool On
        {
            get
            {
                return on;
            }
        }
    }
}
