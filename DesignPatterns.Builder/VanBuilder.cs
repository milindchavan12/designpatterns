using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class VanBuilder : VehicleBuilder
    {
        public AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            vanInProgress = van;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building car body");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("Building car chassis");
        }

        public override void BuildReinforceStorageArea()
        {
            Console.WriteLine("Building car storage area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building car windows");
        }

        public override IVehicle Vehicle
        {
            get { return vanInProgress; }
        }
    }
}
