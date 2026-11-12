using System;

namespace Calculator
{
    internal class Program
    {
        static double a = 0;
        static double b = 0;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"A = {a}, B = {b}");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию \"+\"");
                Console.WriteLine("4. Выполнить операцию \"-\"");
                Console.WriteLine("5. Выполнить операцию \"*\"");
                Console.WriteLine("6. Выполнить операцию \"/\"");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите пункт: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": InputA(); break;
                    case "2": InputB(); break;
                    case "3": Add(); break;
                    case "4": Subtract(); break;
                    case "5": Multiply(); break;
                    case "6": Divide(); break;
                    case "0": return;
                    default: Console.WriteLine("Нет такого пункта"); break;
                }
            }
        }

        static void InputA()
        {
            Console.Write("Введите A: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("Это не число, введите A ещё раз: ");
        }

        static void InputB()
        {
            Console.Write("Введите B: ");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.Write("Это не число, введите B ещё раз: ");
        }

        static void Add()
        {
            Console.WriteLine($"A + B = {a + b}");
        }

        static void Subtract()
        {
            Console.WriteLine($"A - B = {a - b}");
        }

        static void Multiply()
        {
            Console.WriteLine($"A * B = {a * b}");
        }

        static void Divide()
        {
            Console.WriteLine("Функция пока не реализована");
        }
    }
}