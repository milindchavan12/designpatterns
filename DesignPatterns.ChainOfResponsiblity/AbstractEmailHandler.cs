using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsiblity
{
    public abstract class AbstractEmailHandler : IEmailHandler
    {
        private IEmailHandler nextHandler;

        public virtual IEmailHandler NextHandler
        {
            set { nextHandler = value; }
        }

        public virtual void ProcessHandler(string email)
        {
            bool wordFound = false;

            if (MatchingWords().Length == 0)
            {
                wordFound = true;
            }
            else
            {
                foreach (var word in MatchingWords())
                {
                    if (email.IndexOf(word) >= 0)
                    {
                        wordFound = true;
                        break;
                    }
                }
            }

            if (wordFound)
            {
                HandleHere(email);
            }
            else
            {
                nextHandler.ProcessHandler(email);
            }
        }

        protected internal abstract string[] MatchingWords();
        protected internal abstract void HandleHere(string email);

        public static void Handle(string email)
        {
            IEmailHandler span = new SpanEmailHandler();
            IEmailHandler sales = new SpanEmailHandler();
            IEmailHandler service = new SpanEmailHandler();
            IEmailHandler manager = new SpanEmailHandler();
            IEmailHandler general = new SpanEmailHandler();

            span.NextHandler = sales;
            sales.NextHandler = service;
            service.NextHandler = manager;
            manager.NextHandler = general;

            span.ProcessHandler(email);
        }
    }
}
