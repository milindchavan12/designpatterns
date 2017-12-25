using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class SuperGreenEngine
    {
        private int engineSize;

        public SuperGreenEngine(int engineSize)
        {
            this.engineSize = engineSize;
        }

        public virtual int EngineSize
        {
            get
            {
                return engineSize;
            }
        }

        public virtual string ToString()
        {
            return this.GetType().Name + " " + this.EngineSize;
        }
    }
}
