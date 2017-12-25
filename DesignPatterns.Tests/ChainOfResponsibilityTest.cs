using DesignPatterns.ChainOfResponsiblity;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class ChainOfResponsibilityTest
    {
        [Test]
        public void EmailHandlerTest()
        {
            //given
            string email = "I need my car to be repaired";

            //when
            AbstractEmailHandler.Handle(email);

            //then
            System.Console.Read();
        }
    }
}
