using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudgetReport
{
    class Program
    {
        static void Main(string[] args)
        {

            var FamilyBudgetReport = new FamilyBudgetReport()
            {
                FamilyName = "Bondarenko",
                Month = "June",
                FoodTotalAmount = 1400,
                GasTotalAmount = 300,
               ElectricityTotalAmount = 200,
                InternetTotalAmount = 100,
                Salary1 = 2000,
                Salary2 = 3000,


            };
            FamilyBudgetReport.Paid();
            Console.ReadLine();
        }

        public class FamilyBudgetReport
        {
            public string FamilyName { get; set; }
            public string Month { get; set; }
            public int FoodTotalAmount { get; set; }
            public int GasTotalAmount { get; set; }

            public int ElectricityTotalAmount { get; set; }
            public int InternetTotalAmount { get; set; }
            public int Salary1 { get; set; }
            public int Salary2 { get; set; }


            public void Paid()
            {
                int totalearned = Salary1 + Salary2;
               int totalpaied = FoodTotalAmount + GasTotalAmount + ElectricityTotalAmount + InternetTotalAmount;
                int totalsaved = totalearned - totalpaied;


                Console.WriteLine( "This is family " + FamilyName + "." + " In June we have earned " + totalearned 
                                   + " UAH and we paied in total " + totalpaied + " UAH fror gas, electricity, interner and food."
                                   + " So in June we saved " + totalsaved + " UAH");
            }

        }
    }

}
