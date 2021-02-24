using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    public class Buses : Vehicle
    {
        public static BrandVehicles ChoiseBusBrandse(Vehicle vehicle)
        {
            ManagmentApp.ShowMessage("Choise brand bus: 1 - Ikarus, 2 - Iveco, 3 - MCV, 4 - Otokar");
            int choiseBrand = ChoiseTypeAndBrand.ChoiseType();
            switch (choiseBrand)
            {
                case 1:
                    vehicle.BrandVehicle = BrandVehicles.Ikarus;
                    vehicle.RentalPrice = DataRentalPrice.IkarusRentalPrice;
                    break;
                case 2:
                    vehicle.BrandVehicle = BrandVehicles.Iveco;
                    vehicle.RentalPrice = DataRentalPrice.IvecoRentalPrice;
                    break;
                case 3:
                    vehicle.BrandVehicle = BrandVehicles.MCV;
                    vehicle.RentalPrice = DataRentalPrice.MCVRentalPrice;
                    break;
                case 4:
                    vehicle.BrandVehicle = BrandVehicles.Otokar;
                    vehicle.RentalPrice = DataRentalPrice.OtokarRentalPrice;
                    break;

            }
            while (vehicle.BrandVehicle == 0)
            {
                ChoiseBusBrandse(vehicle);

            }
            return vehicle.BrandVehicle;

        }
    }
}
