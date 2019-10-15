using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_practice_3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] multiArray = new char[3, 2] { { 'a', 'b' }, { 'c', 'd' }, { 'e', 'f' } };
            Console.WriteLine(multiArray.GetLength(0));
            Console.ReadLine();
        }
    }
}
