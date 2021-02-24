using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{

    public class Vehicle
    {
        public int Id { get; set; }
        public BrandVehicles BrandVehicle { get; set; }
        public decimal RentalPrice { get; set; }
        public TypeVichle TypeVehicle { get; set; }
        public delegate void Action();
        public event Action ShowMessage;
        public event Action WriteToEventLog;
        public bool IsRentVehicle
        {
            get { return IsRentVehicle; }
            set { IsRentVehicle = value; }


        }
        public Vehicle()
        { }
        public Vehicle(int id, BrandVehicles brandVehicle, TypeVichle typeCar, decimal rentaPrice)
        {
            Id = id;
            BrandVehicle = brandVehicle;
            TypeVehicle = typeCar;
            RentalPrice = rentaPrice;
        }
       
        public void Message()
        {
            WriteToEventLog?.Invoke();
             
            ShowMessage?.Invoke();
        }


    }
    

    


}
