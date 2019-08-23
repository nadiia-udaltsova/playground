using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace выражение_if___else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 33;
            if (x ==8)
            { Console.WriteLine("Value of x is 8");
                Console.ReadKey();
            }
            else if (x==18)
            {
              Console.WriteLine("Value of x is 18");
              Console.ReadKey();
            }
            else if (x == 33)
            {
                Console.WriteLine("Value of x is 33");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No match");
                Console.ReadKey();
            }
            //Outputs "Value of x is 33"
        }
    }
}
