using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using DesignPatterns.Prototype;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class PrototypeTest
    {
        [Test]
        public void VehicleManagerTest()
        {
            //given
            VehicleManager manager = new VehicleManager();

            //when
            IVehicle saloon1 = manager.CreateSaloon();
            IVehicle pickup = manager.CreatePickup();

            //then
            Assert.AreEqual(saloon1.GetType(), typeof(Saloon));
            Assert.AreEqual(pickup.GetType(), typeof(Pickup));
        }
    }
}
