using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class_29._09
{
    class Program
    {
        static void Main(string[] args)
        {
 
            var flydubai = new Airport()
            {
                Country = "Dubai",
                Name = "Flydubai",
                Size = 2.200,
                Number_of_flights = 10,
                Website = "www.flydubai.com",
            };
            var alitalia = new Airport()
            {
                Country = "Italy",
                Name = "Alitalia",
                Size = 3.500,
                Number_of_flights = 25,
                Website = "www.alitalia.com",
            };
            var airbus = new Plane()
            {
                Type = "passenger's",
                Name = "Airbus",
           
                Price = 300.0000000,

            };
            var Boeing = new Plane()
            {
                Type = "Cargo",
                Name = "Boeing",
               
                Price = 350.0000000,
            };

            var turkishAirlines = new Airport()
            {
                Country = "Turkey",
                Name = "Turkish Airlines",
                Size = 3.000,
                Number_of_flights = 15,
                Website = "https://www.turkishairlines.com",
                Planes = new Plane[]
                {
                    Boeing, airbus
                }
            };

            turkishAirlines.Remodel();
            turkishAirlines.Remodel(100);
        

            string airportMessage = turkishAirlines.MayBeClosed() ? "Can be closed" : "Should continue working";

            Console.WriteLine(" The size of the airport in " + turkishAirlines.Country + " " + turkishAirlines.Size + "." + turkishAirlines.CountPrice());
            // Размер аэропорта в такой-то стране столько-то. Общая стоимость самолетов + имя = )
            Console.ReadLine();
        }

    }
}
