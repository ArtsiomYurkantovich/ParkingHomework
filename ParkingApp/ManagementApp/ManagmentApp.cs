using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    class ManagmentApp
    {
        private static bool RequestedExit;
        public static void RunApplication()
        {
            while (!RequestedExit)
            {
                ShowCommands();
                WaitForCommand();
            }
        }

        private static void WaitForCommand()
        {
            int command;

            while (!int.TryParse(Console.ReadLine(), out command))
            {
                ShowErrorMsg($"Command doesn't exist\n");
            }

            ApplyCommand(command);
        }

        public static void ApplyCommand(int command)
        {
            switch ((Menu)command)
            {
                case Menu.AddVehicle:
                    AddNewVehicle.AddNewListVehicle();
                    break;
                case Menu.ChoiseVehicle:
                    RentVehicle.ChoosingCarForRent();   
                    break;
                case Menu.ShowVehiclesPArking:
                    ShowVehicle.ShowVehicleInParking();
                    break;
                case Menu.RemoveVehicle:
                    RemoveFromListVehicle.RemoveFromList();
                    break;
                case Menu.Clear:
                    Console.Clear();
                    break;
                case Menu.Exit:
                    RequestedExit = true;
                    break;

            }
        }

     
        public static void ShowCommands()
        {
            ShowMessage("\nSELECT ONE OF THE COMMANDS!!!\n");
            ShowMessage(
                        $"1 - Add new car",
                        $"2 - Choice of car for rent.",
                        $"3 - Show all cars in the parking lot.",
                        $"4 - Remove a car from the parking list.",
                        $"5 - Clear console content.",
                        $"6 - Exit the application.");
        }
        public static void ShowMessage(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var msg in msgs)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowErrorMsg(params string[] msgs)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var msg in msgs)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
