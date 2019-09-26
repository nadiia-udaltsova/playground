using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var familyIvanovyReport = new Utilities()
            {
                FamilyName = "Ивановы",
                Year = 2017,
                WaterTotalAmount = 1800,
                GasTotalAmount = 2400,
                ElectricityTotalAmount = 3000,
                InternetTotalAmount = 1200,
                HouseMaintenance = 3240,
                Salary1 = 78000,
                Salary2 = 102000,

            };
            

            var familyPetrovyReport = new Utilities()
            {
                FamilyName = "Петровы",
                Year = 2017,
                WaterTotalAmount = 2500,
                GasTotalAmount = 3700,
                ElectricityTotalAmount = 5000,
                InternetTotalAmount = 2000,
                HouseMaintenance = 4040,
                Salary1 = 100000,
                Salary2 = 130000,
            };
            familyIvanovyReport.Paid();
            
            familyIvanovyReport.IncreaseGasTotal(700);
            familyPetrovyReport.IncreaseGasTotal(1500);
            familyIvanovyReport.DecreaseGasTotal(200);
            familyPetrovyReport.DecreaseGasTotal(550);

            familyIvanovyReport.Paid();

            Console.ReadLine();
        }
        
    }
    public class Utilities
    {
        public string FamilyName { get; set; }
        public int Year { get; set; }
        public int WaterTotalAmount { get; set; }
        public int GasTotalAmount { get; set; }

        public int ElectricityTotalAmount { get; set; }
        public int InternetTotalAmount { get; set; }
        public int HouseMaintenance { get; set; }
        public int Salary1 { get; set; }
        public int Salary2 { get; set; }
        public void Paid()
        {
           int totalUtilitiesPaid = WaterTotalAmount + GasTotalAmount + ElectricityTotalAmount + InternetTotalAmount + HouseMaintenance;
           int totalFamilyBudget = Salary2 + Salary1;
           int totalSaved = totalFamilyBudget - totalUtilitiesPaid;
            Console.WriteLine("В " + Year + " семья " + FamilyName + " заработали " + totalFamilyBudget + "."
                               + " Из них им пришлось потратить " + totalUtilitiesPaid + " на коммунальные услуги."
                               + " Оставшуюся сумму " + totalSaved + " они потратили на нужды семьи.");
        }
        public void IncreaseGasTotal (int summa)
        {
            GasTotalAmount = GasTotalAmount + summa;

            /*Console.WriteLine("В 2018 году растраты на газ семьи " + FamilyName + " увеличились на " + summa + " гривен и они стали платить " 
                               + totalGasIncrease + " гривен за газ.");*/
        }
        public void DecreaseGasTotal (int summa)
        {
           GasTotalAmount = GasTotalAmount - summa;
        }
    }
}
