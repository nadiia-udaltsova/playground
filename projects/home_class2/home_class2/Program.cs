using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cake = new Food()
            {
                Type = "cake",
                Portion = 8,
                Taste = "sweet",
            };
            var solyanka = new Food()
            {
                Type = "solyanka",
                Portion = 5,
                Taste = "salty",
                
            };
            var sauerkraut = new Food()
            {
                Type = "sauerkraut",
                Portion = 6,
                Taste = "sour",
            };

            cake.Cook(" my mother", 2);
            solyanka.Cook("my aunt", 3);
            sauerkraut.Cook("my grandmother", 72);
            Console.ReadLine();

            cake.Buy("peaches", 250);
            solyanka.Buy("meat", 300);
            sauerkraut.Buy("cabbage", 60);
            Console.ReadLine();

            cake.Regale("my sister", "on her Birthday");
            solyanka.Regale("my friend", "for dinner");
            sauerkraut.Regale("our neighbor", "on Monday");
            Console.ReadLine();

            cake.Keep("in a dark place", 3);
            solyanka.Keep("in a fridge", 5);
            sauerkraut.Keep("in a fridge", 7);
            Console.ReadLine();
        }
    }
    public class Food
    {
        public string Type { get; set; }
        public int Portion { get; set; }
        public string Taste { get; set; }
        public void Cook (string person, int hours)
        {
            Console.WriteLine(" On weekend " + person + " decided to cook " + Type + " on " + Portion + " portions" + ".\n"
                                 + " it take`s " + hours + " hours" + ".");
        }
        public void Buy (string main_ingredient, int price)
        {
            Console.WriteLine(Type + " has "+ Taste + " taste" + ".\n"
                               + " The main ingredient " + " - "+ main_ingredient + ".\n"
                               + " This dish coust us " + price + " hryvnia" + "." );
        }
        public void Regale (string human, string time)
        {
            Console.WriteLine("We decided to regale " + Type + " to " + human + " " + time + "." );
        }
        public void Keep (string place, int day)
        {
            Console.WriteLine("We can keep " + Type + " " + place + " for " + day + " days" + ".");
        }
    }
         
}
