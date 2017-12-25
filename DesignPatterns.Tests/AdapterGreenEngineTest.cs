using DesignPatterns.Adapter;
using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatterns.Tests
{
    [TestFixture]
    public class AdapterGreenEngineTest
    {
        [Test]
        public void GreenEngineTest()
        {
            IList<IEngine> engines = new List<IEngine>();

            engines.Add(new StandardEngine(1300));
            engines.Add(new StandardEngine(1600));
            engines.Add(new TurboEngine(2000));

            SuperGreenEngine greenEngine = new SuperGreenEngine(1200);
            engines.Add(new SuperGreenEngineAdapter(greenEngine));

            foreach (var engine in engines)
            {
                System.Console.WriteLine(engine);
            }

         }
    }
}
