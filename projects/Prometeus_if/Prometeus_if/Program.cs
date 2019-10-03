using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prometeus_if
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Марк";
            if (name == "марк")
            {
                Console.WriteLine("Привіт, Марк.");
            }
            else
            {
                Console.WriteLine("Привіт, Незнайомець.");
            }

            Console.ReadLine();
        }
    }
}
