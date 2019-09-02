


namespace Moto
{
    public class Car
    {
        public string Color { get; set; }
        public int Age { get; set; }


        public void Run()
        { 

        }

        public void Start()
        {

        }

        public void Break()
        {

        }
    }

    public static class EifelTower
    {
        public static void Shine()
        {

        }
    }

    public class Engine
    {

    }

    public class Driver
    {

    }
}

namespace practice1
{
    using System;
    using Moto;
    using Things;
    public static class Programm
    {
        public static void Main(string[] args)
        {
            var jeans = new Cloth() {
                Size = 30, Type = "jeans", Mark = "Adidass", 
            };
            var dress = new Cloth()
            {
                Size = 48, Type = "dress", Mark = "Gucci",
            };

            jeans.Wash();
            jeans.Shew();
            dress.Wash();
            dress.Shew();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

namespace Things
{
    using System;
    public class Cloth
    {
        public int Size { get; set; }
        public string Type { get; set; }
        public string Mark { get; set; }
        public void Wash()
        {
            string readableSize = Size < 40 ? "small" : "big";
            /*string readableSize = "";

            if (Size < 40)
            {
                readableSize = "small";
            }
            else
            {
                readableSize = "big";
            }*/

            string message = "I Wash " + Type + " of size " + Size + " And it is a " + readableSize + " item";
            Console.WriteLine(message);
        }

        /*
             I'm sewing jeans of size 30 with mark Adidass
             I'm sewing dress of size 48 with mark Gucci
        */
  
        
        
       

    


        public void Shew ()
        {
            Console.WriteLine("I`m sewing " + Type + " of size" + Size + " with mark " + Mark);
        }
    }
}


        


