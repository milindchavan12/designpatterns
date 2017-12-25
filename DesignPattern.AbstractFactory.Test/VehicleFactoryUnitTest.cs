using DesignPatterns.AbstractFactory;
using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using NUnit.Framework;

namespace DesignPattern.AbstractFactory.Test
{
    [TestFixture]
    public class VehicleFactoryUnitTest
    {
        [Test]
        public void CarFactoryTest()
        {
            //given
            AbstractVehicleFactory factory = new CarFactory();

            //when
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChasis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            //then
            Assert.AreEqual(vehicleBody.GetType(), typeof(CarBody));
            Assert.AreEqual(vehicleChasis.GetType(), typeof(CarChassis));
            Assert.AreEqual(vehicleGlassware.GetType(), typeof(CarGlassware));
        }

        [Test]
        public void VanFactoryTest()
        {
            //given
            AbstractVehicleFactory factory = new VanFactory();

            //when
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChasis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            //then
            Assert.AreEqual(vehicleBody.GetType(), typeof(VanBody));
            Assert.AreEqual(vehicleChasis.GetType(), typeof(VanChassis));
            Assert.AreEqual(vehicleGlassware.GetType(), typeof(VanGlassware));
        }
    }
}
