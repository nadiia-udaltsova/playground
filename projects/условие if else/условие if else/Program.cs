using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace условие_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 85;
            if(mark < 50)
            {
                Console.WriteLine("You failed.");
            }
            else
            {
                Console.WriteLine("You passed.");
                Console.ReadKey();
            }
            //Outputs "You passed."
        }
    }
}
