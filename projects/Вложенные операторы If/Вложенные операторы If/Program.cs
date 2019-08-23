using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вложенные_операторы_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 18;
            if (age > 14)
            {
                if (age > 18)
                {
                    Console.WriteLine("Adult");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Teenager");
                    Console.ReadKey();
                }
            }
            else
            {
                if (age > 0)
                {
                    Console.WriteLine("Child");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Something`s wrong");
                    Console.ReadKey();
                }
            }
        }
    }
}
