using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class Plane : IVehicle , IVehicleDal
    {
        public string VehicleName { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public int VehiclePower { get; set; }
        public int VehicleCapasity { get; set; }
        public double WingSpan { get; set; }
        public string EngineType { get; set; }


        public void AddVehicle(List<IVehicle> Vehicle, IVehicle vehicle)
        {
            throw new NotImplementedException();
        }


        public void ListVehicle(List<IVehicle> Vehicle)
        {
            throw new NotImplementedException();
        }


        public void SellVehicle(List<IVehicle> Vehicle, IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
