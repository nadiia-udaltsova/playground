using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home5_18_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] car = { "Ford", "Mazda", "Toyota", "Lanos", "Hunday", "BMW" };
            int amount = 7;
            int price = 5500;
            string color = "Grey";
            Drive(car, amount, price, color);
            Console.ReadLine();
        }

        static void Drive(string[] car, int amount, int price, string color)
        {
            for (int i = 0; i < car.Length; i++ )
            {
                Console.WriteLine(car[i]);
                Console.WriteLine(amount);
                Console.WriteLine(price);
                Console.WriteLine(color);
            }
        }
    }
}
