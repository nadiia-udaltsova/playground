using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace class_building
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var cat = new Pet()
            {
                Type = "Cat"
            };
            var dog = new Pet()
            {
                Type = "Dog"
            };

            cat.Walk("garden", 500);
            dog.Walk("street", 400);
            dog.GoToDoctor("Jack", "Monday", 2, "chicken pox");
            Console.ReadLine();
         }


    }

    public class Pet
    {
        public string Type { get; set; }
        public string Breed { get; set; }
        public void Walk(string place, int distance)
        {
            Console.WriteLine("I`m " + Type + "."+ "I Walk in the " + place + ".\n" +
                              "I walk " + distance);
        }
        public void Treat()
        {

        }

        public void GoToDoctor(string doctorName, string dayOfWeek, int times, string reason)
        {
            Console.WriteLine(Type + " goes to doctor " + doctorName + " " 
                + times + " times per week on " + dayOfWeek + " because " + reason);
        }
    }

    public class Stationery
    {
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public void Buy ()
        {

        }
        public void Package ()
        {

        }
    }
}
