using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class EngineManagementSystem
    {
        private Ignition ignition;
        private Gearbox gearbox;

        public EngineManagementSystem()
        {

        }

        public virtual void RegisterIgnition(Ignition ignition)
        {
            this.ignition = ignition;
        }

        public virtual void RegisterGearbox(Gearbox gearbox)
        {
            this.gearbox = gearbox;
        }

        public virtual void GearboxDisabled()
        {
            throw new NotImplementedException();
        }

        public virtual void GearboxEnabled()
        {
            throw new NotImplementedException();
        }

        public virtual void IngitionTurnedOff()
        {
            throw new NotImplementedException();
        }

        public virtual void IngitionTurnedOn()
        {
            throw new NotImplementedException();
        }

        public virtual void GearChanged()
        {
            throw new NotImplementedException();
        }
    }
}
