using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать управление оператором switch посредством строк.

namespace string_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "один", "два", "три", "два", "один" };

            foreach (string s in strs)
            {
                switch (s)
                {
                    case "один":
                        Console.Write(1);
                        Console.ReadLine();
                        break;
                    case "два":
                        Console.Write(2);
                        Console.ReadLine();
                        break;
                    case "три":
                        Console.Write(3);
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}
