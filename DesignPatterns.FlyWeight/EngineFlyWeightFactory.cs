using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWeight
{
    public class EngineFlyWeightFactory
    {
        public IDictionary<int?, IEngine> standardEngineTool;
        public IDictionary<int?, IEngine> turboEnginTool;

        public EngineFlyWeightFactory()
        {
            standardEngineTool = new Dictionary<int?, IEngine>();
            turboEnginTool = new Dictionary<int?, IEngine>();
        }

        public virtual IEngine GetStandardEngine(int size)
        {
            IEngine e = null;
            bool found = standardEngineTool.TryGetValue(size, out e);

            if (!found)
            {
                e = new StandardEngine(size);
                standardEngineTool[size] = e;
            }

            return e;
        }

        public virtual IEngine GetTurboEngine(int size)
        {
            IEngine e = null;
            bool found = turboEnginTool.TryGetValue(size, out e);

            if (!found)
            {
                e = new TurboEngine(size);
                turboEnginTool[size] = e;
            }

            return e;
        }
    }
}
