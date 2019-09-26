using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Вывести все аргументы командной строки.

namespace Main_args
{
    class CLDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Командная строка содержит " + args.Length + " аргумента");
            Console.WriteLine("Вот они: ");
            for (int i = 0; i < args.Length; i++)
                Console.WriteLine(args[i]);
            Console.ReadLine();
        }
    }
}
