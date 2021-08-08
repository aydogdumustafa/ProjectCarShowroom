using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class VehicleDal : IVehicleDal
    {
        public void AddVehicle(List<IVehicle> Vehicles, IVehicle vehicle)
        {
            Vehicles.Add(vehicle);
        }

        public void ListVehicle(List<IVehicle> Vehicles)
        {
            Console.WriteLine("List of vehicles ");
            foreach (IVehicle i in Vehicles)
            {
                Console.Write("{0}\t", i.VehicleName);
            }
            Console.WriteLine();
        }

        public void SellVehicle(List<IVehicle> Vehicles, IVehicle vehicle)
        {
            Console.WriteLine(vehicle.VehicleName + " has been sold"); 
            Vehicles.Remove(vehicle);
        }
    }
}
