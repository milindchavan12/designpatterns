using DesignPatterns.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class SuperGreenEngineAdapter : AbstractEngine
    {
        public SuperGreenEngineAdapter(SuperGreenEngine greenEngine) : base(greenEngine.EngineSize, false)
        {

        }
    }
}
