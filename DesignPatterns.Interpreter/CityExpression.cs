using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class CityExpression : IExpression
    {
        private City city;

        public CityExpression(City city)
        {
            this.city = city;
        }

        public virtual City Interpret()
        {
            return city;
        }
    }
}
