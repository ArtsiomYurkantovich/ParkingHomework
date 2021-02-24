using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class RentVehicle
    {
        public static void ChoosingCarForRent()
        {
            ManagmentApp.ShowMessage("\nEnter ID vehicle do you want rent:");
            int Id = InputVerificationID.NoVehiclesWithId();
            var vehicle = ShowVehicle.Vehicles.SingleOrDefault(r => r.Id == Id);
            ManagmentApp.ShowErrorMsg($"Your vehicle that you rented.");

            ShowVehicle.Vehicles.Remove(vehicle);

            ShowVehicle.InformationVehicle(vehicle);
            EventLogWorking.message = $" You rented {vehicle.TypeVehicle}, brand: {vehicle.BrandVehicle}, price {vehicle.RentalPrice}$ per 10 minutes.";
            vehicle.WriteToEventLog += EventLogWorking.InformationEventLog;
            vehicle.Message();


        }
    }
}
