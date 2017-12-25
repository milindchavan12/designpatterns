using DesignPatterns.Singleton;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class SingletonTest
    {
        [Test]
        public void SerialNumberGeneratorTest()
        {
            //given
            var expectedFirst = 1;
            var expectedSecond = 2;
            var expectedThird = 3;

            //when
            var acutalSerialOne = SerialNumberGenerator.Instance.NextSerial;
            var acutalSerialTwo = SerialNumberGenerator.Instance.NextSerial;
            var acutalSerialThree = SerialNumberGenerator.Instance.NextSerial;

            //then
            Assert.AreEqual(expectedFirst, acutalSerialOne);
            Assert.AreEqual(expectedSecond, acutalSerialTwo);
            Assert.AreEqual(expectedThird, acutalSerialThree);
        }
    }
}
