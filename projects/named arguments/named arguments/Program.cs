using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Применить именованные аргументы.

namespace named_arguments
{
    class NamedArgsDemo
    {
        // Выяснить, делится ли одно значение нацело на другое.

        static bool IsFactor (int val, int divisor)
        {
            if ((val % divisor) == 0) return true;
            return false;
        }
        static void Main ()
        {
            // Ниже демонстрируются разные способы вызова метода IsFactor().
            // Вызов с использованием позиционных аргументов.

            if (IsFactor(10, 2))
                Console.WriteLine("2 - множитель 10.");

            // Вызов с использованием именованных аргументов.

            if (IsFactor (val: 10, divisor: 2))
                Console.WriteLine("2 - множитель 10.");
            // Для именованного аргумента порядок указания не имеет значения.

            if (IsFactor(divisor: 2, val: 10))

                Console.WriteLine("2 - множитель 10.");

            // Применить как позиционный, так и именованный аргумент.

            if (IsFactor(10, divisor: 2))
                Console.WriteLine("2 - множитель 10.");
            Console.ReadLine();

        }
    }
}
