using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prometeus_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            
            Console.WriteLine("Задайте число 1,2 или 3");
            number = Console.ReadLine();
            if (number == "1")
            {
                string s = "спорт";
                Console.WriteLine(s);
            }
            else if (number == "2")
            {
                Console.WriteLine("прогулка");

            }
            else if (number == "3")
            {
                Console.WriteLine("програмирование");
            }
            else
            {
                Console.WriteLine("неккоректное введение");
            }
            Console.ReadLine();
             
        }
    }
}
