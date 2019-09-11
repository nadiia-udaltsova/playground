using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    // Вычислить среднее арифметическое ряда значений.
    class Average
    {
        static void Main(string[] args)
        {
            int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };
            int avg = 0;

                for (int i = 0; i < 10; i++)
            avg = avg + nums[i];
            avg = avg / 10;
            Console.WriteLine("Среднее: " + avg);
            Console.ReadLine();
        }
    }
}
