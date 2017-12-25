using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Interpreter
{
    public class DirectionalEvaluator
    {
        private IDictionary<string, City> cities;

        public DirectionalEvaluator()
        {
            cities = new Dictionary<string, City>();

            cities["mumbai"] = new City("Mumbai", 57.9, 34.8);
            cities["delhi"] = new City("Delhi", 233.6, 34.8);
            cities["culcutta"] = new City("Culcutta", 34.5, 34.8);

        }

        public virtual City Evaluate(string route)
        {
            Stack<IExpression> expressionStack = new Stack<IExpression>();

            foreach (string token in SplitTokens(route))
            {
                if (cities.ContainsKey(token))
                {
                    var city = cities[token];
                    expressionStack.Push(new CityExpression(city));
                }
                else if (token.Equals("northerly"))
                {
                    expressionStack.Push(new MostNortherlyExpression(LoadExpression(expressionStack)));
                }
                else if (token.Equals("southerly"))
                {
                    expressionStack.Push(new MostSoutherlyExpression(LoadExpression(expressionStack)));
                }
                else if (token.Equals("westerly"))
                {
                    expressionStack.Push(new MostWesterlyExpression(LoadExpression(expressionStack)));
                }
                else if (token.Equals("easterly"))
                {
                    expressionStack.Push(new MostEasterlyExpression(LoadExpression(expressionStack)));
                }
            }

            return expressionStack.Pop().Interpret();
        }

        private IList<string> SplitTokens(string str)
        {
            IList<string> tokens = new List<string>();

            int fromIndex = 0;
            bool finished = false;
            while (!finished)
            {
                int spaceLocation = str.IndexOf(" ", fromIndex);
                if (spaceLocation >= 0)
                {
                    tokens.Add(str.Substring(fromIndex, spaceLocation - fromIndex));
                    fromIndex = spaceLocation + 1;
                }
                else
                {
                    tokens.Add(str.Substring(fromIndex));
                    finished = true;
                }
            }

            return tokens;
        }

        private IList<IExpression> LoadExpression(Stack<IExpression> expressionStack)
        {
            IList<IExpression> expressions = new List<IExpression>();
            while (expressionStack.Count() > 0)
            {
                expressions.Add(expressionStack.Pop());
            }

            return expressions;
        }
    }
}
