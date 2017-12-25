using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine)
            : base(engine, VehicleColour.Unpainted)
        {

        }

        public Coupe(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {

        }

        public override int Price
        {
            get { return 7000; }
        }
    }
}
