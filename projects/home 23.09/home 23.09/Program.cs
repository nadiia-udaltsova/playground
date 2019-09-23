using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_23._09
{
    class Program
    {
        static void Main(string[] args)
        {

            var YearlyCompanyReport = new YearlyCompanyReport()
            {
                Name = "Toyota",
                Year = 2019,
                WorkersCount = 10,
                SalaryPerMonth = 500,
                WorkingMonthCount = 10,
                TaxPercent = 0.10,


            };
            YearlyCompanyReport.Paid();
            Console.ReadLine();
        }

        public class YearlyCompanyReport
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public int WorkersCount { get; set; }
            public int SalaryPerMonth { get; set; }

            public int WorkingMonthCount { get; set; }
            public double TaxPercent { get; set; }
            public void Paid()
            {
                double totalpaid = SalaryPerMonth * WorkingMonthCount * TaxPercent;
                int totalCompanyPaid = SalaryPerMonth * WorkersCount * WorkingMonthCount;
                Console.WriteLine("This is company " + Name + " that has " + WorkersCount + " employeers."
                                   + " Average salary is " + SalaryPerMonth + "." + " Company paid to employeers "
                                   + totalCompanyPaid + " USD during 2019 and employeers paid in total " + totalpaid 
                                   + " USD tax " + " (tax rate " + TaxPercent +").");
            }

        }
    }
}
