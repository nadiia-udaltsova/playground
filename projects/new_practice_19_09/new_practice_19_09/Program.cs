using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_practice_19_09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1projectCommands = { "Проект создан", "сохранить проект", "распечатать проект" };
            string[] s1databaseCommands = { "Внести клиентов в базу", "сделать холодные звонки", "сформировать отчет" };
            Print(s1projectCommands, s1databaseCommands);
        

            var report = new Report()
            {
                GasPrice = 5,
                GasAmount = 10,


            };
             report.Print();
        
            Console.ReadLine();
        }
      
        static void Print (string[] projectCommands, string[] databaseCommands)
        {
            for (int i = 0; i < projectCommands.Length; i++)
            {
                Console.WriteLine(projectCommands[i]);
            }
            for (int x = 0; x < databaseCommands.Length; x++)
            {
                Console.WriteLine(databaseCommands[x]);
            }
        }
            
    }
    public class Report
    {
        public int GasPrice { get; set; }
        public int GasAmount { get; set; }
        public void Print()
        {
           int totalGasPrice = GasPrice * GasAmount;
            Console.WriteLine("Привет я Report." + "Суммарная цена за газ " + totalGasPrice);
        }
        
    }


    /*
     
      YearlyCompanyReport

        Name
        Year
        WorkersCount
        SalaryPerMonth
        WorkingMonthCount

        TaxPercent


      This is company Totyota that has 10 employees. Average salary is 5000. Company paid to employees 50000 USD during 2019
      and employees paied in total 5000 USD tax (tax rate 0.10).


    ----------
    FamilyBudgetReport
       FamilyName
       Month
       FoodTotalAmount
       GasTotalAmount
       ElectricityTotoalAmount
       InternetTotalAmount
       Salary1
       Salary2

     This is family Bondarenko. In june we have earned 5000 UAH and we paied in total 2000 UAH for gas, electiciy, internet and food.
     So in we saved 3000 UAH in june


    ------------
      Create your own report
     
     
     */
}
