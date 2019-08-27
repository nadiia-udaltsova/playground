using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incremet_de
{
    //продемонстрировать отличие между префиксной и 
    //постфиксной формами оператора инкремента (++)
    class PrePostDemo
    {
        static void Main(string[] args)
        {
            int x, y;
            int i;

            x = 1;
            y = 0;
            Console.WriteLine("Ряд чисел, полученных" + "с помощью оператора y= y+ x++");
            for(i=0; i<10; i++)
            { y = y + x++; //постфиксная форма оператора ++
                Console.WriteLine(y + "");
            }
            Console.WriteLine();
            x = 1;
            y = 0;
            Console.WriteLine("Ряд чисел, полученных" + "с помощью оператора y=y+ ++x");
            for(i=0; i<10; i++)
            { y = y + ++x;//префиксная форма оператора ++
                Console.WriteLine(y + "");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
