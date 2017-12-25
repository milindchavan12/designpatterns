using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using DesignPatterns.FactoryMethod;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class FactoryMethodTests
    {
        [Test]
        public void CarFactoryMethodTest()
        {
            //given
            VehicleFactory carFactory = new CarFactory();

            //When
            IVehicle car = carFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColour.Blue);

            //then
            Assert.AreEqual(car.GetType(), typeof(Saloon));
        }

        [Test]
        public void VanFactoryMethodTest()
        {
            //given
            VehicleFactory vanFactory = new VanFactory();

            //When
            IVehicle van = vanFactory.Build(VehicleFactory.DrivingStyle.Economical, VehicleColour.Blue);

            //then
            Assert.AreEqual(van.GetType(), typeof(Pickup));
        }

        [Test]
        public void StaticFactoryMethodTest()
        {
            //given
           
            //When
            IVehicle van = VehicleFactory.Make(VehicleFactory.Category.Car, VehicleFactory.DrivingStyle.Powerful, VehicleColour.Silver);

            //then
            Assert.AreEqual(van.GetType(), typeof(Sport));
        }
    }
}
