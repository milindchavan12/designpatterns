﻿using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities
{
    public class VanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get { return "Chassis parts for Van"; }
        }
    }
}
