using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperators
{
    //Продемонстрировать применение операторов
    // отношения и логических операторов.
    class RelLogOps
    {
        static void Main(string[] args)
        {
            int i, j;
            bool b1, b2;

            i = 10;
            j = 11;
            if (i < j) Console.WriteLine("i<j");
            if (i <= j) Console.WriteLine("i<=j");
            if (i != j) Console.WriteLine("i!=j");

            if (i == j) Console.WriteLine("Нельзя выполнить");
            if (i >= j) Console.WriteLine("Нельзя выполнить");
            if (i > j) Console.WriteLine("Нельзя выполнить");

            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("Нельзя выполнить");
            if (!(b1 & b2)) Console.WriteLine("!(b1&b2) - true");
            if (b1 | b2) Console.WriteLine("b1|b2=true");
            if (b1 ^ b2) Console.WriteLine("b1^b2 - true");

            Console.ReadLine();

        }
    }
}
