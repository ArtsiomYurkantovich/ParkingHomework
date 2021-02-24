using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class PassengerCars : Vehicle
    {

        public static BrandVehicles ChoiseCarMake(Vehicle vehicle)
        {
            ManagmentApp.ShowMessage("Choise brand car: 1 - Audi, 2 - Cadillac, 3 - Honda, 4 - Nissan,  5 - Peugeot");
            int choiseBrand = ChoiseTypeAndBrand.ChoiseType();
            switch (choiseBrand)
            {
                case 1:
                    vehicle.BrandVehicle = BrandVehicles.Audi;
                    vehicle.RentalPrice = DataRentalPrice.AudiRentalPrice;
                    break;
                case 2:
                    vehicle.BrandVehicle = BrandVehicles.Cadillac;
                    vehicle.RentalPrice = DataRentalPrice.CadillacRentalPrice;
                    break;
                case 3:
                    vehicle.BrandVehicle = BrandVehicles.Honda;
                    vehicle.RentalPrice = DataRentalPrice.HondaRentalPrice;
                    break;
                case 4:
                    vehicle.BrandVehicle = BrandVehicles.Nissan;
                    vehicle.RentalPrice = DataRentalPrice.NissanRentalPrice;
                    break;
                case 5:
                    vehicle.BrandVehicle = BrandVehicles.Peugeot;
                    vehicle.RentalPrice = DataRentalPrice.PeugeotRentalPrice;
                    break;
            }
            while (vehicle.BrandVehicle == 0)
            {
                ChoiseCarMake(vehicle);

            }
            return vehicle.BrandVehicle;

        }



    }
}
