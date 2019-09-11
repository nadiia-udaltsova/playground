using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_array
{
    // Вычислить среднее арифметическое ряда значений
    class Average
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int avg = 0;

            nums[0] = 99;
            nums[1] = 10;
            nums[2] = 100;
            nums[3] = 18;
            nums[4] = 78;
            nums[5] = 23;
            nums[6] = 63;
            nums[7] = 9;
            nums[8] = 87;
            nums[9] = 49;

            for (int i = 0; i < 10; i++)
                avg = avg + nums[i];
            avg = avg / 10;
            Console.WriteLine("Среднее: " + avg);
            Console.ReadLine();
        }
    }
}
