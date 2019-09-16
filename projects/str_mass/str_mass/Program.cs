using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать массивы строк.

namespace str_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "Это", "очень", "простой", "текст." };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
            Console.WriteLine("\n");

            // Изменить строку.
            str[1] = "тоже";
            str[3] = "до предела тест!";

            Console.WriteLine("Видоизмененный массив: ");
            for (int i = 0; i < str.Length; i++)
                Console.Write(str[i] + " ");

        }
    }
}
