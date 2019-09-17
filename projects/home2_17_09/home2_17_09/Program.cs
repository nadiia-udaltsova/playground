using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2_17_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = { 1, 2, 5, 10, 25, 50 };
            Count(money);
            Console.ReadLine();

        }

        private static void Count (int [] coins)
        {
            for (int i = 0; i < coins.Length; i++) 
            {
                Console.WriteLine (coins[i]);
            }
        }
    }
}
