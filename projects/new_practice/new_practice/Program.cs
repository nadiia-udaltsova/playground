using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_practice
{
    /*
     1) найти багу и пофиксить
     2) написать 20 методов в каждом по 5 параметров и вызвать их
        ptintXXXX int[] string
        printYYY string[], string, int
        .....
         */
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringsToPrint =  { "Мы учим массивы строк",
                "существуют ступенчатые массивы", "также используют многомерные массивы" };
            PrintStrings(stringsToPrint );
            Console.ReadLine();


        }

        private static void PrintStrings(string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings [i]);
                
            }
                
        }


    } 
    
}
