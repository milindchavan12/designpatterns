using DesignPatterns.Bridge;
using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class BridgePatternTests
    {
        [Test]
        public void DriverControlBridgeTest()
        {
            IEngine engine = new StandardEngine(1300);
            StandardControls standard = new StandardControls(engine);
            standard.IngitionOn();
            standard.Accelerate();
            standard.Break();
            standard.IgnitionOff();

            SportControls sports = new SportControls(engine);
            sports.IngitionOn();
            sports.Accelerate();
            sports.AccelerateHard();
            sports.Break();
            sports.IgnitionOff();
        }
    }
}
