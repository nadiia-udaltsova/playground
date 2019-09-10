using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dress = new Newthing()
            {
                Type = "dress",
                Brand = "RicaMare",
                Style = "cocktail dresses",
            };

            var pants = new Newthing()
            {
                Type = "pants",
                Brand = "Cardo",
                Style = "classic",
            };

            var jacket = new Newthing()
            {
                Type = "jacket",
                Brand = "Hard",
                Style = "down jacket",
            };

            dress.Sale(2500, "dressa.com.ua");
            pants.Sale(800, "born2be.com.ua");
            jacket.Sale(3500, "gohard.com.ua");
            Console.ReadLine();

            dress.Prepare("my birthday", "next week");
            pants.Prepare("work", "on this weekend");
            jacket.Prepare("winter time", "next month");
            Console.ReadLine();

            dress.Exchange("my sister", "after 2 month");
            pants.Exchange("my friend", "after 2 weeks");
            jacket.Exchange("my colleague", "after 3 month");
            Console.ReadLine();
        }
    }

    public class Newthing
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Style { get; set; }
        public void Sale(int price, string place)
        {
            Console.WriteLine("I decided to buy " + Type + " by brand " + Brand + " on site " + place + " for " + price + " hryvnia");
        }
        public void Prepare(string @event, string time)
        {
            Console.WriteLine("I prepare for " + @event + " " + time + " so I decided to buy " + Type);
        }
        public void Exchange (string human, string time)
        {
            Console.WriteLine("I like to exchange clothers. " + " For example, I exchange " 
                              + Type + " with " + human + " " +  time + "using");
        }
    }

}
