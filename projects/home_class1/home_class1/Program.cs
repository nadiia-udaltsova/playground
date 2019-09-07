using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class1
{
    class Program
    {
        static void Main(string[] args)
        {
            var toyota = new Car()
            {
                PlaceNumber = "12345",
                Age = 1999,
                Model = "Toyota",
                Producer = "Japan",
                Country = "Ukraine",
                EngineType = "petrol",
            };
            var ford = new Car()
            {
                PlaceNumber = "43569",
                Age = 2005,
                Model = "Ford",
                Producer = "USA",
                Country = "Poland",
                EngineType = "Gas",
            };
            var Mazda = new Car()
            {
                PlaceNumber = "78904",
                Age = 2017,
                Model = "Mazda",
                Producer = "Korea",
                Country = "Russia",
                EngineType = "diesel",
            };

            toyota.PerfomCheck("Sergiis place", 500);
            ford.PerfomCheck("Warsaws place", 700);
            Mazda.PerfomCheck("Vladimirs place", 900);
            Console.ReadLine();

            toyota.Repair("Best CTO", "engine");
            ford.Repair ("Karl`s CTO", "electrical wiring");
            Mazda.Repair("Jons CTO", "weel");
            Console.ReadLine();

            toyota.Sell("Kirill Pertovich", 2500);
            ford.Sell("Oksana Ivanova", 4000);
            Mazda.Sell("Peter Vladimirovich", 15000);
            Console.ReadLine();

            toyota.Travel("France", 2600);
            ford.Travel("Ukraine", 1200);
            Mazda.Travel("Belarus", 4500);
            Console.ReadLine();
        }
    }
    public class Car
    {
        public string PlaceNumber { get; set; }
        public int Age { get; set; }
        public string Model { get; set; }
        public string Producer { get; set; }
        public string Country { get; set; }
        public string EngineType { get; set; }
        public void PerfomCheck (string stationName, int money )
        {
            Console.WriteLine("I`m " + Model + " with number " + PlaceNumber + " and build on " + Age + " and I work fine.\n"
                                + " Now I`m under check at " + stationName + " for " + money + " euros");
        }
        public void Repair (string CTO, string part)
        {
            Console.WriteLine("I`m " + Model + " and now I`m situated at " + CTO + "," + " because I need to repair my " + part + ".");
        }
        public void Sell (string owner, int price)
        {
            Console.WriteLine("I`m " + Model + " and my owner " + owner + " decided to sell me for " + price + " dollars");
        }
        public void Travel (string country, int distance)
        {
            Console.WriteLine("I`m " + Model + " and my owner decided to travel to " + country + ".\n"
                               + " It`s near " + distance + " kilometers" + ".");
        }
    }

}
