using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class_29._09
{
    class Aircraft
    {
       public string Type { get; set; }
       public double Price { get; set; }
       public int Amount { get; set;}
       public string Name { get; set; }
        public double CountPrice ()
        {
           double TotalPrice = Price * Amount;
            return TotalPrice;
        }
        public void Fly()
        {
            int dictance = 200;
            if (dictance < 200)
            {
                Console.WriteLine(" I can't fly to the airport ");
            }
        }


    }
}
