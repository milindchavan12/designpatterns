using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using DesignPatterns.Business.Entities;
using DesignPatterns.Builder;
using DesignPatterns.Business.Entities.Interfaces;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class BuilderPatternTest
    {
        [Test]
        public void CarBuilderPatternTest()
        {
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector vehicleDirector = new CarDirector();
            IVehicle veh = vehicleDirector.Build(builder);

            Console.WriteLine(veh);
        }
    }
}

