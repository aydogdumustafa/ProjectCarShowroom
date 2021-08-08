using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class VehicleService
    {
        private IVehicleDal _vehicleDal;
        

        public VehicleService(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }

        public void AddVehicle(List<IVehicle> Cars, IVehicle car)
        {   
             _vehicleDal.AddVehicle(Cars, car);
        }
        public void ListVehicle(List<IVehicle> Cars)
        {
            _vehicleDal.ListVehicle(Cars);
        }

        public void SellVehicle (List<IVehicle> Cars, IVehicle car)
        {
            _vehicleDal.SellVehicle(Cars,car);
        }
    }
}
