using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get { return "Glassware parts for Car"; }
        }
    }
}
