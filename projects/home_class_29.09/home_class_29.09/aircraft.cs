using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_class_29._09
{
    class Plane    {
       public string Type { get; set; }
       public double Price { get; set; }
       
       public string Name { get; set; }
        
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
