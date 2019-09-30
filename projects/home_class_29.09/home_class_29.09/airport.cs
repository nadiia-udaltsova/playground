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
        public int Number_of_flights { get; set; }
        public string Website { get; set; }
        public void Remodel ()
        {
           // а если размер 5000 - достаточно, иначе строим дальше

            int newNumber_of_flights = Number_of_flights == 20 ? 35 : 45;
            Number_of_flights = newNumber_of_flights;
        }
        public bool MayBeClosed ()
        {
            return Number_of_flights < 10;
        }
    }
}
