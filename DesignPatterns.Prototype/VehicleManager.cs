using DesignPatterns.Business.Entities;
using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    public class VehicleManager
    {
        private IVehicle saloon, coupe, sport, pickup, boxVan;

        public VehicleManager()
        {
            saloon = new Saloon(new StandardEngine(1300));
            coupe = new Coupe(new StandardEngine(1300));
            sport = new Sport(new StandardEngine(1300));
            pickup = new Pickup(new StandardEngine(1300));
            boxVan = new BoxVan(new StandardEngine(1300));
        }

        public virtual IVehicle CreateSaloon()
        {
            return (IVehicle)saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            return (IVehicle)pickup.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            return (IVehicle)boxVan.Clone();
        }
    }
}
