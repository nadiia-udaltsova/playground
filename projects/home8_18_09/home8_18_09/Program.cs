using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home8_18_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]clothes = { "Dress", "Pants", "Jaket", "Blouse", "Shorts" };
            int amount = 3;
            int price = 650;
            string color = "White";
            int stores = 4;
            Buy(clothes, amount, price, color, stores);
            Console.ReadLine();
        }
        static void Buy(string[]clothes, int amount, int price, string color, int stores)
        {
            for (int i = 0; i < clothes.Length; i++)
            {
                Console.WriteLine(clothes);
                Console.WriteLine(amount);
                Console.WriteLine(price);
                Console.WriteLine(color);
                Console.WriteLine(stores);
            }
        }
    }
}
