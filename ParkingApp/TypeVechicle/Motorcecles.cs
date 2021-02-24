using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class Motorcecles : Vehicle
    {
        public static BrandVehicles ChoiseMotorcycleBrandse(Vehicle vehicle)
        {
            ManagmentApp.ShowMessage("Choise brand motorcycle : 1 - BMW, 2 - Yamaha, 3 - Kawasaki, 4 - Ducati");
            int choiseBrand = ChoiseTypeAndBrand.ChoiseType();
            switch (choiseBrand)
            {
                case 1:
                    vehicle.BrandVehicle = BrandVehicles.BMW;
                    vehicle.RentalPrice = DataRentalPrice.BMWRentalPrice;
                    break;
                case 2:
                    vehicle.BrandVehicle = BrandVehicles.Yamaha;
                    vehicle.RentalPrice = DataRentalPrice.YamahaRentalPrice;
                    break;
                case 3:
                    vehicle.BrandVehicle = BrandVehicles.Kawasaki;
                    vehicle.RentalPrice = DataRentalPrice.KawasakiRentalPrice;
                    break;
                case 4:
                    vehicle.BrandVehicle = BrandVehicles.Ducati;
                    vehicle.RentalPrice = DataRentalPrice.DucatiRentalPrice;
                    break;
               
            }
            while (vehicle.BrandVehicle == 0)
            {
                ChoiseMotorcycleBrandse(vehicle);

            }
            return vehicle.BrandVehicle;

        }
    }
}
