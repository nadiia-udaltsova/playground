using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classShop
{
    class Buyer
    {
        public int AverageAge { get; set; }
        public string Gender { get; set; }
        public int AmountPerDay { get; set; }

        public bool StartDiscount ()
        {
            return AmountPerDay < 100;
        }
            

    }
}
