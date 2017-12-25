using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using DesignPatterns.Decorator;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class DecoratorTest
    {
        [Test]
        public void CarDecoratorTest()
        {
            //given
            IVehicle car = new Saloon(new StandardEngine(1300));
            car.Paint(VehicleColour.Blue);

            //when
            car = new AlloyWheeledVehicle(car); //AlloyWheeled
            car = new LeatherSeatedVehicle(car); //LeatherSeated
            car = new MetalicPaintedVehicle(car); //MetalicPaintedVehicle
            car = new SatNavVehicle(car); //SateliteNavigation

            System.Console.WriteLine(car);
        }
    }
}
