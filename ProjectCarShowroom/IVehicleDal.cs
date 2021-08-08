using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    interface IVehicleDal
    {
        void AddVehicle(List<IVehicle> Vehicle, IVehicle vehicle);
        void SellVehicle(List<IVehicle> Vehicle, IVehicle vehicle);
        void ListVehicle(List<IVehicle> Vehicle);

    }
}
