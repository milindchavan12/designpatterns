using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Business.Entities.Interfaces
{
    public interface IVehicle : ICloneable
    {
        IEngine Engine { get; }
        VehicleColour VehicleColour { get; }

        void Paint(VehicleColour colour);

        int Price { get; }
    }

    public enum VehicleColour
    {
        Unpainted,
        Blue,
        Black,
        Green,
        Red,
        Silver,
        White,
        Yellow
    }
}
