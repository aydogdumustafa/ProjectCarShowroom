using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class Lorry : IVehicle
    {
        public string VehicleName { get; set; }
        public string VehicleColor { get ; set ; }
        public string VehicleBrand { get ; set ; }
        public int VehiclePower { get ; set ; }
        public int VehicleCapasity { get; set ; }
        public int WheelNumber { get; set; }
        public string GearType { get; set; }
        public string TruckType { get; set; }
    }
}
