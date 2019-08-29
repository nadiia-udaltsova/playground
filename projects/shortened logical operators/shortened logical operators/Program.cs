using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shortened_logical_operators
{
    class SCops
    {
        static void Main(string[] args)
        {
            int n, d;

            n = 10;
            d = 2;
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(n + "делится нацело на" + d);

            d = 0; //задать нулевое значение переменной d.
            // d равно 0, поэтому второй операнд не вычесляется

            if (d != 0 && (n % d) == 0) 
            Console.WriteLine(n + "делится нацело на" + d);

            //Если теперь попытаться сделать тоже самое без укороченного
            // логического оператора, то возникнет ошибка из-за деления на 0.

            if (d != 0 & (n % d) == 0)
                Console.WriteLine(n + "делится нацело на" + d);
            Console.ReadLine();

        }
    }
}
