using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCarShowroom
{
    class Car : IVehicle
    {
        public string VehicleName { get; set; }
        public string VehicleColor { get; set; }
        public string VehicleBrand { get; set; }
        public int VehiclePower { get; set; }
        public int VehicleCapasity { get; set; }
        public string GearType { get; set; }
        

        //public void AddVehicle(List<IVehicle> Cars,IVehicle car)
        //{
        //    Cars.Add(car);
        //}



        //public void ListVehicle(List<IVehicle> Vehicles)
        //{
        //    foreach (IVehicle i in Vehicles)
        //    {
        //        Console.Write("{0}\t", i.VehicleName);
        //    }
        //    Console.WriteLine();
        //}
    


        //public void SellVehicle(List<IVehicle> Vehicle, IVehicle vehicle)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
