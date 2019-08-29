using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace someCondition
{
    //продемонстрировать значение побочных эффектов.
    class SideEffects
    {
        static void Main(string[] args)
        {
            int i;
            bool someCondition = false;
            i = 0;
            //Значение переменной i инкрементируется,
            // несмотря на то, что оператор if не выполняется.
            if (someCondition & (++i < 100))
                Console.WriteLine("Не выводится");
            Console.WriteLine(" Оператор if выполняется:" + 1);//выводится 1.

            //В данном случае значение переменной i не инкрементируется,
            //поскольку инструмент в укороченном логическом операторе опускается.

            if (someCondition && (++i < 100))
                Console.WriteLine("Не выводится");
            Console.WriteLine("Оператор if выполняется:" + 1); //по прежнему 1!!!
            Console.ReadLine();

        }
    }
}
