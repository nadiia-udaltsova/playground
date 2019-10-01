using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given three numbers, write a method that adds two first ones and multiplies them by a third one.
//Expected input and output
// AddAndMultiply(2, 4, 5) → 30

namespace CSharpExercises
{
   
    class AddAndMultiplyTask
    {
        public static double AddAndMultiply (double a, double b, double c)
        {
            return (a + b) * c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddAndMultiply(2, 4, 5));
            Console.WriteLine(AddAndMultiply(3, 6, 35));
            Console.WriteLine(AddAndMultiply(1.7, 9.9, 0.01));
            Console.ReadLine();
        }
    }
}
