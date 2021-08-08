using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class Car : IVehicle, IVehicleService
    {
        public string VehicleName { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public int VehiclePower { get; set; }
        public int VehicleCapasity { get; set; }
        public string GearType { get; set; }
        

        public void AddVehicle(List<IVehicle> Cars,IVehicle car)
        {
            Cars.Add(car);
        }

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
