using DesignPatterns.Interpreter;
using NUnit.Framework;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class InterpreterTest
    {
        [Test]
        public void CitiesIntepreterTest()
        {
            //given
            DirectionalEvaluator evaluator = new DirectionalEvaluator();

            System.Console.WriteLine(evaluator.Evaluate("mumbai culcutta delhi westerly"));

        }
    }
}
