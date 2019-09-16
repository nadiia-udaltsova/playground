using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massiv1
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 10;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = i;
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("'Элемент массива с индексом " + i + " имеет значение " + array[i]);
                Console.ReadLine();
            }
        }
    }
}
