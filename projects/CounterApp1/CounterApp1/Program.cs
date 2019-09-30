using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 45 };

            bool result = c1 > c2;
            Console.WriteLine(result);

            Counter c3 = c2 + c1;
            Console.WriteLine(c3.Value);

            Console.ReadKey();
        }
    }
    class Counter
    {
        public int Value { get; set; }
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }
        public static bool operator >(Counter c1, Counter c2)
        {
            if (c1.Value > c2.Value)
                return true;
            else
                return false;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            if (c1.Value < c2.Value)
                return true;
            else
                return false;
        }

    }
}
