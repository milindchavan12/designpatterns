﻿using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildChassis();
            builder.BuildPassengerArea();
            builder.BuildBoot();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
