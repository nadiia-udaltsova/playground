using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask1
{
    public class Human
    {
        static void Main(string[] args)
        {
            var Peter = new Human()
            {
                Age = 39, Name = "Peter", Profession = "programmer", Location = "London",
                Children = 2,
            };
            var Vasya = new Human()
            {
                Age = 33, Name = "Vasya", Profession = "driver", Location = "Liverpool",
                Children = 3,
            };
            Peter.DescribeMyself();
            Vasya.DescribeMyself();
        }

            
                public int Age { get; set; }
                public string Name { get; set; }
                public string Profession { get; set; }
                public string Location { get; set; }
                public int Children { get; set; }
                public void DescribeMyself()
        {
            int amt = Children <= 2 ? 2 : 3;
            Console.WriteLine("My name is " + Name + ". " + " I work as " + Profession + ". " + " I`m " + Age + " and I live in "
          + Location + ". " + " I have " + amt + " children" + ".");
            Console.ReadLine();
        }

        }
    }
