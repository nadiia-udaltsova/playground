using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classShop
{
    class Shop
    {
        public string Item { get; set; }
        public int Number_of_employees { get; set; }
        public int AverageSalary { get; set; }
        public int Profit { get; set; }
        public int SpendMoney_on_staff()
        {
            TotalSpending_on_staff = Number_of_employees * AverageSalary;
            return TotalSpending_on_staff;
        }
        public bool CloseStore()
        {
            return Profit < 50000;
        }
    }
}
