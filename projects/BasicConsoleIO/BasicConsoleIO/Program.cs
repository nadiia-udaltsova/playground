using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserData();
        }
        static void GetUserData()
        {
            //Получить информацию об имени и возрасте.
            Console.Write("Please,enter your name:"); //Предложить ввести имя
            string userName = Console.ReadLine();
            Console.Write("Please, enter your age:"); //Предложить ввести возраст
            string userAge = Console.ReadLine();

            //Просто ради забавы изменить цвет переднего плана.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Вывести полученною информацию на консоль.
            Console.WriteLine("Hello {0}! You are {1} years old.",
                userName, userAge);
            //Восстановить предыдущий цвет переднего плана.
            Console.ForegroundColor = prevColor;

        }
    }

}
