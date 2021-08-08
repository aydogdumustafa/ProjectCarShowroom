using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class Car : IVehicle
    {
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public int VehiclePower { get; set; }
        public int VehicleCapasity { get; set; }
    }
}
