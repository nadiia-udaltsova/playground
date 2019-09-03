using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakDemo
{
    //Применить оператор Break для выхода из цикла.
    class BreakDemo
    {
        static void Main(string[] args)
        {
            //Использовать оператор break для выхода из этого цикла.
            for (int i = -10; i <= 10; i++)
            {
                if (i > 0) break; // завершить цикл, как только значение переменной i станет положительным.
                Console.WriteLine (i + " ");
            }
            Console.WriteLine("Готово!");
            Console.ReadLine();
        }
        
    }
}
