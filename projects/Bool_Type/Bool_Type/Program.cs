using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_Type
{
    class BoolDemo
    {
        static void Main(string[] args)
        {
            bool b;
            b = false;

            Console.WriteLine("b равно" + b);
            b = true;
            Console.WriteLine("b равно" + b);

            //логическое значение может управлять оператором if.
            if (b) Console.WriteLine("выполняется");
            b = false;
            if (b) Console.WriteLine("не выполняется");
            //результатом выполнения оператора отношения
            //является логическое значение.
            Console.WriteLine("10>9 равно " + (10 > 9));
            Console.ReadLine();

        }
    }
}
