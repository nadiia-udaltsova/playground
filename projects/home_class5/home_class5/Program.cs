using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class5
{
   public class Program
    {
        static void Main(string[] args)
        {
            var Fridge = new equipment()
            {
                Type = "fridge",
                Model = " KGN39UW306",
                Brand = "Bosch",
            };
            var mobile_phone = new equipment()
            {
                Type = "mobile phone",
                Model = "Redmi Note 5",
                Brand = "Xiomi",
            };

            var TV = new equipment()
            {
                Type = "TV",
                Model = "UE43N5000AUXUA",
                Brand = "Samsung",
            };

            Fridge.Sale(11300, "December 2019");
            mobile_phone.Sale(5200, "February 2020");
            TV.Sale(15200, "December 2021");
            Console.ReadLine();

            Fridge.Buy(7, "Bigopt company");
            mobile_phone.Buy(11, "L'CarouseL company");
            TV.Buy(5, "Skladoptom company");
            Console.ReadLine();

            Fridge.Repair(2, "for the last 2 month");
            mobile_phone.Repair(7, "for the last 5 month");
            TV.Repair(5, "for the last year");
            Console.ReadLine();

            Fridge.Win(2, "on New Year");
            mobile_phone.Win(3, "on anniversary our store");
            TV.Win(1, "on Valentine's Day");
            Console.ReadLine();
        }
    }

    public class equipment
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        public void Sale(int price, string deadlines)
        {
            Console.WriteLine("On our store we should sale " + Type + " " + Brand + " "
                               + Model + " and deadline " + deadlines + ".\n" + " Starting price " + price + " hryvnia ");

        }
        public void Buy(int amount, string provider)
        {
            Console.WriteLine("For our store we want to Buy " + amount + " " + Type
                               + " " + Brand + " in our provider " + provider + ".");
        }

        public void Repair(int amount, string time)
        {
            Console.WriteLine("We repaired " + amount + " " + Type + " " + Brand + " " + time);
        }
        public void Win(int amount, string holiday)
        {
            Console.WriteLine("Our store we had give away " + amount + " " + Type + " " + holiday);
        }
    }
}
