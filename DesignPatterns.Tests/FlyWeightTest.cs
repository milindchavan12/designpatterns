using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using DesignPatterns.FlyWeight;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class FlyWeightTest
    {
        [Test]
        public void EngineFlyWeightFactoryTest()
        {
            var factory = new EngineFlyWeightFactory();

            IDiagnosticTool tool = new EngineDiagnosisTool();

            var standard1 = factory.GetStandardEngine(1300);
            standard1.Diagnose(tool);

            var standard2 = factory.GetStandardEngine(1300);
            standard2.Diagnose(tool);

            var standard3 = factory.GetStandardEngine(1300);
            standard3.Diagnose(tool);

            System.Console.WriteLine(standard1.GetHashCode());
            System.Console.WriteLine(standard2.GetHashCode());
            System.Console.WriteLine(standard3.GetHashCode());
        }
    }
}
