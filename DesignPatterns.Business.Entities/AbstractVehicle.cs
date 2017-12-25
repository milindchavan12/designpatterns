using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine engine;
        private VehicleColour colour;

        public AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            this.engine = engine;
            this.colour = colour;
        }

        public virtual IEngine Engine
        {
            get { return engine; }
        }

        public virtual VehicleColour VehicleColour
        {
            get { return colour; }
        }

        public virtual void Paint(VehicleColour colour)
        {
            this.colour = colour;
        }

        public abstract int Price
        {
            get;
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + engine + ", " + colour + ", Price : " + Price + ")";
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
