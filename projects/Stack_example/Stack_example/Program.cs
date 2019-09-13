using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Продемонстрировать применение класса Stack.

namespace Stack_example
{
  
    // Класс для хранения символов в стеке.
    class Stack
    // Эти члены класса являются закрытыми.
    {
        char[] stck; // массив, содержащий стек
        int tos; // индекс вершины стека

        // Построить пустой класс Stack для реализации стека заданного размера.
        public Stack (int size)
        {
            stck = new char[size]; // распределить память для стека
            tos = 0;
        }
        // Поместить символы в стек.
        public void Push (char ch)
        {
            if (tos == stck.Length)
            {
                Console.WriteLine(" - Стек заполнен.");
                return;
            }
            stck[tos] = ch;
            tos++;
        }
        // Извлечь символ из стека.
        public char Pop ()
        {
            if (tos == 0)
            {
                Console.WriteLine(" - Стек пуст.");
                return (char)0;
            }
            tos--;
            return stck[tos];
        }
        // Возвратить значение true, если стек заполнен.
        public bool IsFull()
        {
            return tos == stck.Length;
        }
        // Возвратить значение true, если стек пуст.
        public bool IsEmpty ()
        {
            return tos == 0;
        }
        // Возвратить общую емкость стека.
        public int Capacity ()
        {
            return stck.Length;
        }
        // Возвратить количество объектов, находящихся в данный момент в стеке.
        public int GetNum ()
        {
            return tos;
        }
    }
    class StackDemo
    {
        static void Main ()
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch;
            int i;

            // Поместить ряд символов в стек stk1.
            Console.WriteLine("Поместить символы А-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

            if (stk1.IsFull ())
                Console.WriteLine("Стек stk1 заполнен.");

            // Вывести содержимое стека stk1.
            Console.Write("Содержимое стека stk1: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }
            Console.WriteLine();
            if (stk1.IsEmpty())
            Console.WriteLine("Стек stk1 пуст.\n");

            // Поместить дополнительные символы в стек stk1
            Console.WriteLine("Вновь поместить символы A-J в стек stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

            // А теперь извлечь элементы из стека stk1 и поместить их в стек stk2.
            // В итоге элементы сохраняются в стеке stk2 в обратном порядке.
            Console.WriteLine(" А теперь извлечь символы из стека stk1\n " + " и поместить их в стек stk2. ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                stk2.Push(ch);
            }
            Console.Write("Содержимое стека stk2: ");
            while (!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }
            Console.WriteLine("\n");

            // Поместить 5 символов в стек.
            Console.WriteLine("Поместить 5 символов в стек stk3.");
            for (i = 0; i < 5; i++)
                stk3.Push((char)('A' + i));

            Console.WriteLine("Емкость стека stk3: " + stk3.Capacity());
            Console.WriteLine("Количество объектов в стеке stk3: " + stk3.GetNum());
            Console.ReadLine();
        }
    }
}
