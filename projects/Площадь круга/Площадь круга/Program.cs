using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Площадь_круга
{
    //вычислить площадь круга.
    class Program { }
        class Circle
    {
        static void Main(string[] args)
        { double radius;
            double area;
            radius = 10.0;
            area = radius * radius * 3.1416;
            Console.WriteLine("Площадь равна" + area);
            Console.ReadLine();

        }
    }
}
