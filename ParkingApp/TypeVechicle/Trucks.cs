using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Trucks : Vehicle
    {
        public static BrandVehicles ChoiseTruckBrandse(Vehicle vehicle)
        {
            ManagmentApp.ShowMessage("Choise brand truck : 1 - Otokar, 2 - Ural, 3 - MAZ, 4 - Magirus");
            int choiseBrand = ChoiseTypeAndBrand.ChoiseType();
            switch (choiseBrand)
            {
                case 1:
                    vehicle.BrandVehicle = BrandVehicles.Otokar;
                    vehicle.RentalPrice = DataRentalPrice.OtokarRentalPrice;
                    break;
                case 2:
                    vehicle.BrandVehicle = BrandVehicles.Ural;
                    vehicle.RentalPrice = DataRentalPrice.UralRentalPrice;
                    break;
                case 3:
                    vehicle.BrandVehicle = BrandVehicles.MAZ;
                    vehicle.RentalPrice = DataRentalPrice.MAZRentalPrice;
                    break;
                case 4:
                    vehicle.BrandVehicle = BrandVehicles.Magirus;
                    vehicle.RentalPrice = DataRentalPrice.MagirusRentalPrice;
                    break;

            }
            while (vehicle.BrandVehicle == 0)
            {
                ChoiseTruckBrandse(vehicle);

            }
            return vehicle.BrandVehicle;

        }
    }
}
