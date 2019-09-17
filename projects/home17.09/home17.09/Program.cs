using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home17._09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentenceFairytale = { "Красная шапочка", "Снежная Королева", "Колобок" };
            Write(sentenceFairytale);
            Console.ReadLine ();
        }

        private static void Write (string [] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }
        }
    }
}
