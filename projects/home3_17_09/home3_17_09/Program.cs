using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home3_17_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 30, 67, 89, 76, 3, 6, 98, 12 };
            int y = 345;
            string car = "Ford";
            PrintandPrint(x, y, car);
            Console.ReadLine();

        }

        static void PrintandPrint(int[] x, int y, string car)
        {
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x[i]);
            Console.WriteLine(y);
            Console.WriteLine(car);
        }
            
    

    }
}
