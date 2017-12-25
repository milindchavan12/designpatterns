using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class AbstractDriverControls 
    {
        private IEngine engine;

        public AbstractDriverControls(IEngine engine)
        {
            this.engine = engine;
        }

        public virtual void IngitionOn()
        {
            engine.Start();
        }

        public virtual void IgnitionOff()
        {
            engine.Stop();
        }

        public virtual void Accelerate()
        {
            engine.IncreasePower();
        }

        public virtual void Break()
        {
            engine.DecreasePower();
        }
    }
}
