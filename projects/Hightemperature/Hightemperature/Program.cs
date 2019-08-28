using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hightemperature
{
    //пример работы логического оператора "укороченное ИЛИ"
    class Program
    {
        static void Main(string[] args)
        {
            bool isHighTemperature = true;
            bool hasNoCooling = true;
            if (isHighTemperature||hasNoCooling)
            {
                Console.WriteLine("Угроза повреждения процессора!!!");
                Console.ReadLine();
            }
        }
    }
}
