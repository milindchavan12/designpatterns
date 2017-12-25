using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public class StandardControls : AbstractDriverControls
    {
        public StandardControls(IEngine engine) : base(engine)
        {

        }
    }
}
