using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newPractice
{
    public class Car
    {
        public int Year { get; set; }
        public int CurrentGasAmount { get; set; }
        public int GasConsumptionPerKm { get; set; }
        public int MaxGas { get; set; } = 100;
        public string Name { get; set; }
        public Man Owner { get; set; }

        public int GetCurrentEmptyGasAmount()
        {
            return MaxGas - CurrentGasAmount;
        }

        public int Run(int distanceKm)
        {
            int spendGasLiters = GasConsumptionPerKm * distanceKm;
            CurrentGasAmount = CurrentGasAmount - spendGasLiters;
            return CurrentGasAmount;
        }

        public void RunMarathon()
        {
            int currentGasAmount = Run(40);
            if (currentGasAmount < 10)
            {
                Console.WriteLine("I have amost no gas after marathon");
            }
        }

        public void LeakAllGas()
        {
            CurrentGasAmount = 0;
        }

        public void SetNewOnwer(Man newOnwer)
        {
            Owner = newOnwer;
        }
    }
}
