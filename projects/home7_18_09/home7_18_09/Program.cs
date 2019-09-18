using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home7_18_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] students = { 34, 67, 89, 90, 112, 157 };
            int age = 20;
            string nationality = "ukrainian";
            Teach(students, age, nationality);
            Console.ReadLine();
        }
        static void Teach(int[] students, int age, string nationality)
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
                Console.WriteLine(age);
                Console.WriteLine(nationality);
            }
        }
    }
}
