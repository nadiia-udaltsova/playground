using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForVar
{
    //Обьявить переменную правления циклом в самом цикле for.
    class ForVar
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int fact = 1;
            //вычислить фактириал чисел от 1 до 5
            for (int i = 1; i <= 5; i++)
            {
                sum += i; //переменная i действует в цикле.
                fact *= i;
            }
            // а здесь переменная i недоступна.
            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Факториал равен " + fact);
        }
    }
}
