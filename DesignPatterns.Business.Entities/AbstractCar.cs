using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine) : base(engine, VehicleColour.Unpainted)
        {

        }

        public AbstractCar(IEngine engine, VehicleColour colour) : base(engine, colour)
        {

        }
    }
}
