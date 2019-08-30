using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_simple
{
    class PosNeg
    {
        static void Main(string[] args)
        {
            int i;
            for (i = -5; i <= 5; i++)
            {
                Console.WriteLine("Проверка:" + i + "");
                if (i < 0) Console.WriteLine("отрицательное число");
                else Console.WriteLine("положительное число");
                Console.ReadLine();
            }

        }
    }
}
