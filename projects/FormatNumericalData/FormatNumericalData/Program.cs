using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumericalData
{
    class Program
    {
        static void Main(string[] args)
        {
            FormatNumerialData();
            Console.ReadKey();
        }
        // Демонстрация применения некоторых дескрипторов формата
        static void FormatNumerialData()
        {
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // обратите внимание, что использование для символа шестнадцатеричного формата
            // верхнего или нижнего регистра определяет регистр отображаемых символов.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
    }
}

