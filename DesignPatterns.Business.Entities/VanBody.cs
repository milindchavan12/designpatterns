using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public class VanBody : IBody
    {
        public virtual string BodyParts
        {
            get { return "Body shell parts for Van"; }
        }
    }
}
