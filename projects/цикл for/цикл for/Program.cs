using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цикл_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            for (; x > 0;) ;
            {
                Console.WriteLine(x);
                x -= 3;
                Console.ReadKey();
            }
        }
    }
}
