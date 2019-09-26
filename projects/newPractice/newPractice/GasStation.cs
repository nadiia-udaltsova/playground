using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newPractice
{
    class GasStation
    {
        public string Owner { get; set; }
        public int PriceGas { get; set; }
        public int PleasesCount { get; set; }
        public int TotalGas { get; set; }

        public string Name { get; set; }

        public void FillCar(Car car)
        {
            int freeTankLiters = car.GetCurrentEmptyGasAmount();

            TotalGas = TotalGas - freeTankLiters;
        }

    }
}
