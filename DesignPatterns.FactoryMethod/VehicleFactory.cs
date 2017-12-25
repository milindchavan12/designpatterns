using DesignPatterns.Business.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical,
            Midrange,
            Powerful
        }

        public enum Category
        {
            Car,
            Van
        }

        public static IVehicle Make(Category category, DrivingStyle style, VehicleColour colour)
        {
            VehicleFactory factory;

            if (category == Category.Car)
                factory = new CarFactory();
            else 
                factory = new VanFactory();

            return factory.Build(style, colour);
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            IVehicle veh = SelectVehicle(style);
            veh.Paint(colour);
            return veh;
        }

        //This is factory method
        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
        
    }
}
