using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class ListVehicleOnParking
    {
        public static void AddPassengerCars()
        {
            ShowVehicle.Vehicles.Add(new Vehicle(1, BrandVehicles.Audi, TypeVichle.PassengerCars, 5));
            ShowVehicle.Vehicles.Add(new Vehicle(2, BrandVehicles.Cadillac, TypeVichle.PassengerCars, 4));
            ShowVehicle.Vehicles.Add(new Vehicle(3, BrandVehicles.Honda, TypeVichle.PassengerCars, 3));
            ShowVehicle.Vehicles.Add(new Vehicle(4, BrandVehicles.Nissan, TypeVichle.PassengerCars, 3));
            ShowVehicle.Vehicles.Add(new Vehicle(5,BrandVehicles.Peugeot, TypeVichle.PassengerCars, 3));
            ShowVehicle.Vehicles.Add(new Vehicle(6, BrandVehicles.Iveco, TypeVichle.Buses, 10));
            ShowVehicle.Vehicles.Add(new Vehicle(7, BrandVehicles.Ikarus, TypeVichle.Buses, 9));
            ShowVehicle.Vehicles.Add(new Vehicle(8, BrandVehicles.Ducati, TypeVichle.Motorcecles, 7));
            ShowVehicle.Vehicles.Add(new Vehicle(9, BrandVehicles.BMW, TypeVichle.Motorcecles, 5));


        }
       

    }
}
