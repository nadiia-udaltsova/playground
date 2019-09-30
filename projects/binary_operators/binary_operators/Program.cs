using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Пример перегрузки бинарных операторов.

namespace binary_operators
{
    class ThreeDDemo
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;

            Console.Write("Координаты точки a: ");
            a.Show();

            Console.WriteLine();
            Console.Write("Координаты точки b: ");
            b.Show();

            Console.WriteLine();
            с = а + b; // сложить координаты точек а и b
            Console.Write("Результат сложения а + b: ");
            с.Show();

            Console.WriteLine();
            с = а + b + с; // сложить координаты точек а, b и с
            Console.Write("Результат сложения а + b + с: ");
            с.Show();
            Console.WriteLine();

            с = с - а; // вычесть координаты точки а
            Console.Write("Результат вычитания с - а: ");
            с.Show();

            Console.WriteLine();
            с = с - b; // вычесть координаты точки b
            Console.Write("Результат вычитания с - b: ");

            с.Show();

            Console.WriteLine();
        }
    }
    // Класс для хранения трехмерных координат.
    class ThreeD
    {
        int х, у, z; // трехмерные координаты
        public ThreeD()
        { х = у = z = 0; }
        public ThreeD(int i, int j, int k) { x = i; у = j; z = k; }

        // Перегрузить бинарный оператор +.
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            /* Сложить координаты двух точек и возвратить результат. */
            result.х = op1.x + ор2.х; // Эти операторы выполняют
            result.у = op1.y + ор2.у; // целочисленное сложение,
            result.z = op1.z + op2.z; // сохраняя свое исходное назначение.
            return result;
        }
        // Перегрузить бинарный оператор -.
        public static ThreeD operator - (ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            /* Обратите внимание на порядок следования операндов:
            op1 — левый операнд, а ор2 — правый операнд. */
            result.х = op1.x - ор2.х; // Эти операторы
            result.у = op1.y - ор2.у; // выполняют целочисленное
            result.z = op1.z - op2.z; // вычитание
            return result;
        }
        // Вывести координаты X, Y, Z.
        public void Show()
        {
            Console.WriteLine(x + ", " + у + ", " + z);
        }
    }


}
