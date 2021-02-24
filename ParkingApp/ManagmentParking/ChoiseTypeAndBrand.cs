using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class ChoiseTypeAndBrand
    {
        public static int ChoiseType()
        {
            int choiseType;

            while (!int.TryParse(Console.ReadLine(), out choiseType))
            {
                Console.WriteLine("Enter correct plese number  type of vehicle.\n");
            }

            return choiseType;
        }

        public static TypeVichle TypeOfVehicles(Vehicle vehicle)
        {
            ManagmentApp.ShowMessage("Choise type vehicle: 1 - Motorcecles, 2 - PassengerCars, 3 - Buses, 4 - Trucks");
            int typeCar = ChoiseType();
            switch (typeCar)
            {
                case 1:
                    vehicle.TypeVehicle = TypeVichle.Motorcecles;
                    Motorcecles.ChoiseMotorcycleBrandse(vehicle);
                    break;
                case 2:
                    vehicle.TypeVehicle = TypeVichle.PassengerCars;
                    PassengerCars.ChoiseCarMake(vehicle);
                    break;
                case 3:
                    vehicle.TypeVehicle = TypeVichle.Buses;
                    Buses.ChoiseBusBrandse(vehicle);
                    break;
                case 4:
                    vehicle.TypeVehicle = TypeVichle.Trucks;
                    Trucks.ChoiseTruckBrandse(vehicle);
                    break;
            }
            while (vehicle.TypeVehicle == 0)
            {
                TypeOfVehicles(vehicle);

            }
            return vehicle.TypeVehicle;

        }

    }
}
