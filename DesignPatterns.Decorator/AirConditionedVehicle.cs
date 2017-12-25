using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class AirConditionedVehicle : AbstractVehicleOption
    {
        public AirConditionedVehicle(IVehicle vehicle) : base(vehicle)
        {

        }

        public override int Price
        {
            get { return decoratedVehicle.Price + 600; }
        }

        public virtual int Temperature
        {
            set
            {

            }
        }
    }
}
