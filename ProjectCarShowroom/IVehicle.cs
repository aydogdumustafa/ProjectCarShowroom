using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    public interface IVehicle
    {
        string VehicleColor { get; set; }
        string VehicleBrand { get; set; }
        int VehiclePower { get; set; }
        int VehicleCapasity { get; set; }
    }
}
