using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class CarFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Economical)
                return new Saloon(new StandardEngine(1000));
            else if (style == DrivingStyle.Midrange)
                return new Coupe(new StandardEngine(1500));
            else
                return new Sport(new TurboEngine(2000));
        }
    }
}
