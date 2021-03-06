﻿using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    public class MetalicPaintedVehicle : AbstractVehicleOption
    {
        public MetalicPaintedVehicle(IVehicle vehicle)
            : base(vehicle)
        {

        }

        public override int Price
        {
            get { return decoratedVehicle.Price + 750; }
        }
    }
}
