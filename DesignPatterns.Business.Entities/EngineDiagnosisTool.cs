using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public class EngineDiagnosisTool : IDiagnosticTool
    {
        public void RunDiagonsis(object obj)
        {
            Console.WriteLine("Starting the Engine diagnosis tool for " + obj);
            Thread.Sleep(5000);
            Console.WriteLine("Finished the Engin diagnosis tool for " + obj);
        }
    }
}
