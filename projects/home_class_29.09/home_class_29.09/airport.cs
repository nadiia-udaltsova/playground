using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class_29._09
{
    class Airport
    {
        public string Country { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }
       public int Amount { get; set; }

        public Plane [] Planes { get; set; }

        public int Number_of_flights { get; set; }
        public string Website { get; set; }
        public void Remodel ()
        {
            // а если размер 5000 - достаточно, иначе строим дальше

            int newNumber_of_flights = Number_of_flights + 10; //Number_of_flights == 20 ? 35 : 45;
            Number_of_flights = newNumber_of_flights;
        }
        public bool MayBeClosed ()
        {
            return Number_of_flights < 10;
        }
        public double CountPrice()
        {
            double summa = 0;
            

            for (int i = 0; i < Planes.Length; i++)
            {
                Plane currentPlane = Planes[i];
                double planePrice = currentPlane.Price;
                summa = planePrice + summa;
            };

            return summa;
        }
    }
}
