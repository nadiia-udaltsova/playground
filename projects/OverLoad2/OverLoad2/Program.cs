using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Неявные преобразования типов могут повлиять на
// решение перегружать метод.

namespace OverLoad2
{
    class Overload2
    {
        public void MyMeth (int x)
        {
            Console.WriteLine("В методе MyMeth (int) " + x);
        }
        public void MyMeth (double x)
        {
            Console.WriteLine("В методе MyMeth (double) " + x);
            Console.ReadLine();
        }
    }
    class TypeConv
    {
        static void Main ()
        {
            Overload2 ob = new Overload2();

            int i = 10;
            double d = 10.1;

            byte b = 99;
            short s = 10;
            float f = 11.5f;

            ob.MyMeth(i); // вызвать метод ob.MyMeth(int)
            ob.MyMeth(d); // вызвать метод ob.MyMeth(double)
            ob.MyMeth(b); // вызвать метод ob.MyMeth(int) - с преобразованием типа
            ob.MyMeth(s); // вызвать метод ob.MyMeth(int) - с преобразованием типа
            ob.MyMeth(f); // вызвать метод ob.MyMeth(double) - с преобразованием типа
        }
    }
}
