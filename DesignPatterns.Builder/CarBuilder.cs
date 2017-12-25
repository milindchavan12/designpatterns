using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        public AbstractCar carInProgress;

        public CarBuilder(AbstractCar car)
        {
            carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building car body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("Building car boot");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("Building car chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("Building car passenger area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building car windows");
        }

        public override IVehicle Vehicle
        {
            get { return carInProgress; }
        }

    }
}
