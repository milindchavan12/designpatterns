using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class MostEasterlyExpression : IExpression
    {
        private IList<IExpression> expressions;

        public MostEasterlyExpression(IList<IExpression> expressions)
        {
            this.expressions = expressions;
        }

        public virtual City Interpret()
        {
            City resultingCity = new City("Nowhere", -999.9, -999.9);

            foreach (IExpression currentExpression in expressions)
            {
                City currentCity = currentExpression.Interpret();
                if (currentCity.Longitude > resultingCity.Longitude)
                {
                    resultingCity = currentCity;
                }
             
            }

            return resultingCity;
        }
    }
}
