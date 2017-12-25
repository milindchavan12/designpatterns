using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class Gearbox
    {
        private EngineManagementSystem mediator;
        private bool enabled;
        private Gear currentGear;

        public Gearbox(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            currentGear = Gear.Neutral;

            mediator.RegisterGearbox(this);
        }

        public virtual void Enable()
        {
            enabled = true;
            mediator.GearboxEnabled();
        }

        public virtual void Disable()
        {
            enabled = false;
            mediator.GearboxDisabled();
        }

        public virtual bool Enabled
        {
            get
            {
                return enabled;
            }
        }

        public virtual Gear Gear
        {
            get
            {
                return currentGear;
            }
            set
            {
                if((Enabled) && (Gear != value))
                {
                    currentGear = value;
                    mediator.GearChanged();
                }
            }
        }
    }

    public enum Gear
    {
        Neutral,
        First,
        Second,
        Third,
        Forth,
        Firth,
        Reverse
    }
}
