using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Строковые_литералы
{
    //Продемонстрировать применение управляющих 
    //последовательностей символов в строковых литералах.
    class StrDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая строка\nВторая строка\nТретья строка");
            Console.WriteLine("Один\tДва\tТри");
            Console.WriteLine("Четыре\tПять\tШесть");

            //Вставить кавычки.
            Console.WriteLine("\"Зачем?\", спросил он.");
            Console.ReadLine();

        }
    }
}
