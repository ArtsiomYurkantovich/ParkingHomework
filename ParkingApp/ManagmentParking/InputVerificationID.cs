using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class InputVerificationID
    {

        public static int EnterIdVehicle()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Enter correct plese ID vechicle.\n");
            }
            return id;
        }

        public static int NoVehiclesWithId()
        {
            int Id = EnterIdVehicle();

            while (!ShowVehicle.Vehicles.Exists(x => x.Id == Id))
            {
                ManagmentApp.ShowErrorMsg("Enter correct ID");
                Id = EnterIdVehicle();
            }
            return Id;
        }

    }
}
