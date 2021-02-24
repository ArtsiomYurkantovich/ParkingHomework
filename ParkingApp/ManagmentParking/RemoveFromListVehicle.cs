using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class RemoveFromListVehicle
    {
        public static int RemoveFromList()
        {
            ManagmentApp.ShowErrorMsg("Enter please ID vehicle that do you dismiss");
            int id = InputVerificationID.NoVehiclesWithId();

            var vehicle = ShowVehicle.Vehicles.SingleOrDefault(r => r.Id == id);

            if (vehicle != null)
            {
                ManagmentApp.ShowErrorMsg($"Vehicle delete with ID: {vehicle.Id}, Car make: {vehicle.BrandVehicle}, Type car: {vehicle.TypeVehicle}.");

                ShowVehicle.Vehicles.Remove(vehicle);

               EventLogWorking.message = $"You remove from parking list. Vehicle ID: {vehicle.Id}, " +
                     $"brand vehicle: { vehicle.BrandVehicle}, " +
                     $"renta price for vehicle: { vehicle.RentalPrice}$ per 10 minutes";

                vehicle.WriteToEventLog += EventLogWorking.InformationEventLog;
                vehicle.Message();
                return id;
            }
            else
            {
                return 0;
            }

        }
    }
}