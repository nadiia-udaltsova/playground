using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesSpop = new Shop()
            {
                Item = "Clothes",
                Number_of_employees = 15,
                AverageSalary = 7500,
                Profit = 50000,
            };
            var homeApplianceStore = new Shop()
            {
                Item = "Home appliance",
                Number_of_employees = 25,
                AverageSalary = 9000,
                Profit = 100000,
            };
            var groceryStore = new Shop()
            {
                Item = "Products",
                Number_of_employees = 45,
                AverageSalary = 8000,
                Profit = 80000,

            };
            groceryStore.SpendMoney_on_staff;
        }
    }
}
