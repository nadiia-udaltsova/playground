using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home6_18_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pumpkin = { 5, 7, 9, 13, 15, 22 };
            int people = 4;
            string variety = "hokkaido";
            int month = 3;
            Grow(pumpkin, people, variety, month);
            Console.ReadLine();
        }
        static void Grow(int[] pumpkin, int people, string variety, int month)
        {
            for (int i = 0; i < pumpkin.Length; i++)
            {
                Console.WriteLine(pumpkin[i]);
                Console.WriteLine(people);
                Console.WriteLine(variety);
                Console.WriteLine(month);
            }
        }
    }
}
