using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine)
            : base(engine, VehicleColour.Unpainted)
        {

        }

        public Sport(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {

        }

        public override int Price
        {
            get { return 8000; }
        }
    }
}
