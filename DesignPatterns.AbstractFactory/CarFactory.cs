using DesignPatterns.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    public class CarFactory : AbstractVehicleFactory
    {
        public override Business.Entities.Interfaces.IBody CreateBody()
        {
            return new CarBody();
        }

        public override Business.Entities.Interfaces.IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override Business.Entities.Interfaces.IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}
