using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class ShowVehicle
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>();

       

        public static void ShowVehicleInParking()
        {
           
            var sortedVehicle = from vehicle in Vehicles
                                orderby vehicle.Id
                                select vehicle;

            foreach (Vehicle vehicle in sortedVehicle)
            {
                ManagmentApp.ShowErrorMsg($"ID: {vehicle.Id} // Type vehicle: {vehicle.TypeVehicle} // " +
                    $"Brand vehicle: {vehicle.BrandVehicle} // Rental price: {vehicle.RentalPrice}$");

                EventLogWorking.message = $" Vehicle ID: {vehicle.Id}, brand vehicle: { vehicle.BrandVehicle}, " +
                   $"renta price for vehicle: { vehicle.RentalPrice}$ per 10 minutes";

                vehicle.ShowMessage += EventLogWorking.InformationEventLog;
                vehicle.Message();
            }

        }

        public static void InformationVehicle(Vehicle vehicle)
        {
            ManagmentApp.ShowMessage(
                        $"Vehicle ID: {vehicle.Id}",
                        $"Type car: {vehicle.TypeVehicle}",
                        $"Brand {vehicle.TypeVehicle}: {vehicle.BrandVehicle}",
                        $"Renta price {vehicle.BrandVehicle}: {vehicle.RentalPrice}$ per 10 minutes");

        }

        public static void ShowVehicleInformation()
        {
            int i = 1;
            var sortedVehichle = from empl in Vehicles
                                 orderby empl.Id
                                 select empl;

            foreach (Vehicle vehicle in sortedVehichle)
            {
                ManagmentApp.ShowErrorMsg($"********* Vehicle:  {vehicle.BrandVehicle}   *********");
                InformationVehicle(vehicle);
                i++;
            }
        }

        public static void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter("Parking", true))
            {
                foreach (var vehicle in Vehicles)
                    sw.WriteLine($"Vehicle ID: {vehicle.Id} , Vehicle make: {vehicle.BrandVehicle}, Type car: {vehicle.TypeVehicle}");
            }
        }

    }
}
