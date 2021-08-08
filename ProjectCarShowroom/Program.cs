using System;
using System.Collections.Generic;

namespace ProjectCarShowroom
{
    class Program
    {
        static void Main(string[] args)
        {

           

            List<IVehicle> Cars = new List<IVehicle>();
            List<IVehicle> Planes = new List<IVehicle>();
            List<IVehicle> Lorries = new List<IVehicle>();

            Car Toyota = new Car() { VehicleName = "Toyota", };
            Plane Airbus = new Plane {VehicleName = "Airbus" };



            Toyota.AddVehicle(Cars,Toyota);
            
            foreach (IVehicle i in Cars)
            {
                Console.Write("{0}\t", i.ToString());
            }
            Console.WriteLine();
        }
    }
}
