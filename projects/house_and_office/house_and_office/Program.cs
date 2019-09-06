using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_and_office
{
    class Building
    {
        public int Floors; //колличество этажей
        public int Area; //общая площадь здания
        public int Occupants; //колличество жильцов

        //Возвратить величину площади на одного человека
        public int AreaPerPerson ()
        {
            return Area / Occupants;
        }

    }
    // использовать значение, возвращаемое методом AreaPerPerson
    class BuildingDemo
    {
        static void Main(string[] args)
        {
            Building house = new Building();
            Building office = new Building();
            int areaPP; // площадь на одного человека

            // присвоить значение полям в объекте house
            house.Occupants = 4;
            house.Area = 2500;
            house.Floors = 2;

            // присвоить значение полям в объекте office.
            office.Occupants = 25;
            office.Area = 4200;
            office.Floors = 3;

            //получить площадь на одного человека в жилом доме.
            areaPP = house.AreaPerPerson();
            Console.WriteLine("Дом имеет:\n " +
                               house.Floors + " этажа\n " +
                               house.Occupants + " жильца\n " +
                               house.Area +
                               " кв.фунтов общей площади, из них \n " +
                               areaPP + " приходится на одного человека ");
            Console.WriteLine();
            // получить площадь на одного человека в учреждении.
            areaPP = office.AreaPerPerson();
            Console.WriteLine("Учреждение имеет:\n " +
                                office.Floors + " этажа\n" +
                                office.Occupants + " работника\n " +
                                office.Area +
                                " кв.фунтов общей площади, из них \n " +
                                areaPP + " приходится на одного человека ");
            Console.ReadLine();

        }
    }
}
