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
            

            Car Toyota = new Car() { VehicleName = "Toyota", GearType = "Automatic", VehicleBrand = "Corolla", VehicleCapasity = 4, VehicleColor = "Red", VehiclePower = 120 };
            Car Tesla = new Car() { VehicleName = "Tesla", GearType = "Automatic", VehicleBrand = "Model3", VehicleCapasity = 4, VehicleColor = "Blue", VehiclePower = 200 };
            Plane Airbus = new Plane { VehicleName = "AirbusA130", EngineType = "propeller", VehicleBrand = "A130", VehicleCapasity = 120, VehicleColor = "White", VehiclePower = 3000, WingSpan = 120 };
            Plane Carrier = new Plane { VehicleName = "Carrier", EngineType = "propeller", VehicleBrand = "T11", VehicleCapasity = 12, VehicleColor = "White", VehiclePower = 2000, WingSpan = 100 };
            Lorry Man = new Lorry { VehicleName = "Man", GearType = "Manual", VehicleBrand = "130", TruckType = "SteelCabin", VehicleCapasity = 3, VehicleColor = "Red", VehiclePower = 400, WheelNumber = 18 };
            Lorry Iveco = new Lorry { VehicleName = "Iveco", GearType = "Manual", VehicleBrand = "a11", TruckType = "SteelCabin", VehicleCapasity = 2, VehicleColor = "White", VehiclePower = 300, WheelNumber = 8 };

            vehicleService.AddVehicle(Cars, Toyota);
            vehicleService.AddVehicle(Cars, Tesla);
            vehicleService.SellVehicle(Cars, Toyota);

            vehicleService.AddVehicle(Planes, Airbus);
            vehicleService.AddVehicle(Planes, Carrier);

            vehicleService.AddVehicle(Lorries, Man);
            vehicleService.AddVehicle(Lorries, Iveco);

            vehicleService.ListVehicle(Cars);
            vehicleService.ListVehicle(Planes);
            vehicleService.ListVehicle(Lorries);

            vehicleService.ListVehicle(AllVehicles);


        }
    }
}
