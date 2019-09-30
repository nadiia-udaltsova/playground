using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dima = new Man()
            {
                Age = 32,
                Gender = "Man",
                Occupation = "driver",

            };

            var toyota = new Car()
            {
                CurrentGasAmount = 40,
                Name = "Toyota",
                Year = 1985,
                Owner = dima,
            };

            
            var station = new GasStation()
            {
               Name = "Oko",
               Owner = "Poroshenko",
               PleasesCount = 4,
               PriceGas = 12,
               TotalGas = 1000
            };


            station.FillCar(toyota);
            int leftGasOnStationLiters = station.TotalGas;
            Console.WriteLine("There are " + leftGasOnStationLiters + " liters left on the gas station");

            Console.ReadKey();
        }
    }


    /*
       Домашнее задние

      Самолет
         летать

      Аэропотр
      CIty




      Shop
      Item
      Customer



     Laptop
     Man





     
     */
}
