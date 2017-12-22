using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership
{
    class Program
    {
        static void Main(string[] args)
        {
            CarInformation car = new CarInformation("Honda","Civic",2015);

            // Car price without discount
            car.setPrice(20000);
            double carPrice = car.getPrice();
            Console.WriteLine(carPrice);

            // Car price with discount
            car.setDiscount(20);
            carPrice = car.getDiscount();
            Console.WriteLine(carPrice);

            Console.WriteLine("Which car do you want to buy?");
            string carChoice = Console.ReadLine();
            if (carChoice == "Honda")
            {
                Console.WriteLine("You picked Honda.");
            }
            else if (carChoice == "Toyota")
            {
                Console.WriteLine("You picked Toyota.");
            }
            else
                Console.WriteLine("We don't have your car.");
        }
    }
}
