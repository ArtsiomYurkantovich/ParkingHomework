using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class AddNewVehicle
    {
        public static void AddNewListVehicle()
        {

            Vehicle vehicle = new Vehicle();
            ManagmentApp.ShowMessage("Enter Id");

            vehicle.Id = InputVerificationID.EnterIdVehicle();

            while (ShowVehicle.Vehicles.Exists(veh => veh.Id == vehicle.Id))
            {
                ManagmentApp.ShowMessage("Enter new ID");
                vehicle.Id = InputVerificationID.EnterIdVehicle();
            }

            ChoiseTypeAndBrand.TypeOfVehicles(vehicle);
            ShowVehicle.InformationVehicle(vehicle);

            ShowVehicle.Vehicles.Add(new Vehicle(vehicle.Id, vehicle.BrandVehicle, vehicle.TypeVehicle, vehicle.RentalPrice));
            EventLogWorking.message = $"Add new vehicle. Vehicle ID: {vehicle.Id}, " +
                     $"brand vehicle: { vehicle.BrandVehicle}, " +
                     $"renta price for vehicle: { vehicle.RentalPrice}$ per 10 minutes";
            vehicle.WriteToEventLog += EventLogWorking.InformationEventLog;
            vehicle.ShowMessage += ShowVehicle.WriteToFile;
            vehicle.Message();
        }

    }
}
