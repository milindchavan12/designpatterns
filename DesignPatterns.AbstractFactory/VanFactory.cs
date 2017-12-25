using DesignPatterns.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class VanFactory : AbstractVehicleFactory
    {
        public override Business.Entities.Interfaces.IBody CreateBody()
        {
            return new VanBody();
        }

        public override Business.Entities.Interfaces.IChassis CreateChassis()
        {
            return new VanChassis();
        }

        public override Business.Entities.Interfaces.IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
