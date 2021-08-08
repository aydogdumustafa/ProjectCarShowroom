using System;
using System.Collections.Generic;


namespace ProjectCarShowroom
{
    class Program
    {
        static void Main(string[] args)
        {

            

            VehicleDal vehicleDal = new VehicleDal();

            VehicleService vehicleService = new VehicleService(vehicleDal);

            


            List<IVehicle> Cars = new List<IVehicle>();
            List<IVehicle> Planes = new List<IVehicle>();
            List<IVehicle> Lorries = new List<IVehicle>();
            List<IVehicle> AllVehicles = new List<IVehicle>();
            // AllVehicles = AllVehicles.Add(Cars);

            Car Toyota = new Car() { VehicleName = "Toyota", };
            Car Tesla = new Car() { VehicleName = "Tesla", };
            Plane Airbus = new Plane {VehicleName = "Airbus" };

            vehicleService.AddVehicle(Cars,Toyota);
            vehicleService.AddVehicle(Cars,Tesla);
            vehicleService.SellVehicle(Cars, Toyota);
            vehicleService.ListVehicle(Cars);


            
            

            
        }
    }
}
