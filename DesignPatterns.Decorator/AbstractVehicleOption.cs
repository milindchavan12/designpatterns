using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public abstract class AbstractVehicleOption : AbstractVehicle
    {
        protected internal IVehicle decoratedVehicle;

        public AbstractVehicleOption(IVehicle vehicle) : base(vehicle.Engine, VehicleColour.Unpainted)
        {
            decoratedVehicle = vehicle;
        }

    }
}
