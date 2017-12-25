using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public class ElectricWindow
    {
        private bool open;

        public ElectricWindow()
        {
            open = false;
            Console.WriteLine("Window is closed");
        }

        public virtual bool Open
        {
            get
            {
                return open;
            }
        }

        public virtual bool Closed
        {
            get
            {
                return !open;
            }
        }

        public virtual void OpenWindow()
        {
            if (Closed)
            {
                open = true;
                Console.WriteLine("Window is now open");
            }
        }

        public virtual void CloseWindow()
        {
            if (Open)
            {
                open = false;
                Console.WriteLine("Window is now closed");
            }
        }
    }
}
