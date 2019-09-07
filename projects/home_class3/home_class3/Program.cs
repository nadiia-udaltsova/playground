using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Java_developer = new recruiting()
            {
                Type = "Java developer",
                Budget = 3000,
                Amount = 1,
                Dedlain = "2 month",
            };
            var Frontend_developer = new recruiting()
            {
                Type = "Frontend developer",
                Budget = 3500,
                Amount = 3,
                Dedlain = "1 month",
                
            };
            var Mobile_developer = new recruiting()
            {
                Type = "Mobile developer",
                Budget = 4000,
                Amount = 2,
                Dedlain = "2 weeks",
            };

            Java_developer.search("hh.ru", "Wallet One");
            Frontend_developer.search("linkedin", "Emotorwerks");
            Mobile_developer.search("our base", "One to Trip");
            Console.ReadLine();

            Java_developer.interviewing("at the morning", "by phone");
            Frontend_developer.interviewing("on dinner", "by Skype");
            Mobile_developer.interviewing("at the evening", "in the office");
            Console.ReadLine();

            Java_developer.to_program(4, "spring framework, mongo db, docker");
            Frontend_developer.to_program(5, "angular 2+");
            Mobile_developer.to_program(5, "Objective-C, iOS SDK, Swagger, Stripe SDK");
            Console.ReadLine();

            Java_developer.Describe(37, "male");
            Frontend_developer.Describe(32, "any");
            Mobile_developer.Describe(30, "male");
            Console.ReadLine();

        }
    }
    public class recruiting
    {
        public string Type { get; set; }
        public int Budget { get; set; }
        public int Amount { get; set; }
        public string Dedlain { get; set; }
        public void search (string resource, string company)
        {
            Console.WriteLine("Our agancy should find " + Amount + " " + Type + " for " + company + " company" + ".\n"
                              + " We will search " + Type + " on " + resource + ".");
        }
         
        public void interviewing (string time, string place)
        {
            Console.WriteLine("According to our plan we will interviewing " + Type + " " + place + " " + time + " time" + ".");
        }

        public void to_program (int experience, string requirements)
        {
            Console.WriteLine("We should find " + Type + " with experience from " + experience
                               + " years " + " and main requirements" + ":" + requirements);
        }
        public void Describe (int age, string sex)
        {
            Console.WriteLine("Companies left a few wishes: " + Type + " should be " 
                              + sex + " sex" + " and be not older than " + age + " years ");
        }
    }
}
