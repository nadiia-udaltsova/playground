using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prometeus_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            string s;
            Console.WriteLine("Задайте значение 1,2 или 3");
            number = Console.ReadLine();

            switch(number)
            {
                case "1": s = "прогулка"; break;
                case "2": s = "спорт"; break;
                case "3": s = "програмирование"; break;
                default: s = "не корректное введение данных"; break;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
