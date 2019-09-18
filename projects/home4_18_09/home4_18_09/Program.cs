using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home4_18_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = { "Garry Pother", "Never Stop", "Shepot volka", "Uzdniki gorizonta" };
            int numers = 2005;
            int shelf = 14;
            string library = "Makeevka";
            Readbooks(books, numers, shelf, library);
            Console.ReadLine();
        }
        static void Readbooks (string[] books, int numers, int shelf, string library)
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
                Console.WriteLine(numers);
                Console.WriteLine(shelf);
                Console.WriteLine(library);
            }
        }
    }
}
