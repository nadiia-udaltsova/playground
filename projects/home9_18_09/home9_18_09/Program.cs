using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home9_18_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] building = { "apartment", "cottage", "country house" };
            int storeys = 5;
            int amount = 8;
            string developer = "Renessans";
            Build(building, storeys, amount, developer);
            Console.ReadLine();

        }
        static void Build(string[] building, int storeys, int amount, string developer)
        {
            for (int i = 0; i < building.Length; i++)
            {
                Console.WriteLine(building [i]);
                Console.WriteLine(storeys);
                Console.WriteLine(amount);
                Console.WriteLine(developer);
            }
        }
    }
}
