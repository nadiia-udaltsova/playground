using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home10_19_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] things = { "dishes", "saucepan", "pan" };
            int amount = 5;
            string day = "Saturday";
            Wash(things, amount, day);
            Console.ReadLine();

        }
        static void Wash (string [] things, int amount, string day)
        {
            for (int i = 0; i < things.Length; i++)
            {
                Console.WriteLine(things [i]);
                Console.WriteLine(amount);
                Console.WriteLine(day);
            }
        }
    }
}
