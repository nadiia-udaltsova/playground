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
            var familyBondarenkoReport = new FamilyBudgetReport()
            {
                FamilyName = "Bondarenko",
                Month = "June",
                FoodTotalAmount = 1400,
                GasTotalAmount = 300,
               ElectricityTotalAmount = 200,
                InternetTotalAmount = 100,
                Salary1 = 2000,
                Salary2 = 3000
            };
            var familyTarasenkoReport = new FamilyBudgetReport()
            {
                FamilyName = "Tarasenko",
                Month = "June",
                FoodTotalAmount = 1700,
                GasTotalAmount = 250,
                ElectricityTotalAmount = 500,
                InternetTotalAmount = 300,
                Salary1 = 4000,
                
                Salary2 = 3500,
            };
            familyTarasenkoReport.PrintSalary();

            familyTarasenkoReport.RaiseSalary(500);

            familyBondarenkoReport.Paid();
            familyTarasenkoReport.Paid();
            familyTarasenkoReport.PrintSalary();

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
                int totalearned = CountSalary();
                int totalpaied = FoodTotalAmount + GasTotalAmount + ElectricityTotalAmount + InternetTotalAmount;
                int totalsaved = totalearned - totalpaied;


                Console.WriteLine("This is family " + FamilyName + "." + " In June we have earned " + totalearned
                                   + " UAH and we paied in total " + totalpaied + " UAH fror gas, electricity, interner and food."
                                   + " So in June we saved " + totalsaved + " UAH");
            }
            public void PrintSalary()
            {
                int totalearned = CountSalary();
                Console.WriteLine("Суммарная зарплата семьи " + FamilyName + totalearned);
            }
            private int CountSalary()
            {
                return Salary1 + Salary2;
            }
            public void RaiseSalary(int summa)
            {
                
                int totalraise = Salary1 + summa;
                Salary1 = totalraise;
            }
            
        }
    }

}
