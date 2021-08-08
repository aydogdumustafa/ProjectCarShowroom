using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class Plane : IVehicle , IVehicleService
    {
        public string VehicleName { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public int VehiclePower { get; set; }
        public int VehicleCapasity { get; set; }
        public double WingSpan { get; set; }
        public string EngineType { get; set; }

        public void AddVehicle()
        {
            throw new NotImplementedException();
        }

        public void ListVehicle()
        {
            throw new NotImplementedException();
        }

        public void SellVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
