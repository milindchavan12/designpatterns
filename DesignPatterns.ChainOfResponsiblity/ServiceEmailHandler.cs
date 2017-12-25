using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsiblity
{
    public class ServiceEmailHandler : AbstractEmailHandler
    {
        protected internal override string[] MatchingWords()
        {
            return new string[] { "service", "reapir" };
        }

        protected internal override void HandleHere(string email)
        {
            Console.WriteLine("This email handled by service department");
        }
    }
}
