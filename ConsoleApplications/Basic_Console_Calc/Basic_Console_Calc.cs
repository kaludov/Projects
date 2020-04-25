//Title: Console Calcutlator
//Description: My first console application.
//Developer: Georgi Kaludov

using System;


namespace Basic_Console_Calc
{
    class Basic_Console_Calc
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                Version();
                Console.WriteLine("Въведете номер за желана операция");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                Console.WriteLine("| 1 събиране | 2 изваждане | 3 умножение | 4 деление | 5 корен квадратен | 6 степенуване | 0 изход |");
                Console.WriteLine("----------------------------------------------------------------------------------------------------");
                string action = Console.ReadLine();
                double a, b, n, result;

                switch (action)
                {
                    case "1":
                        Version();
                        Console.WriteLine("Операция събиране");
                        Console.WriteLine("-----------------");
                        InputValues(out a, out b);
                        result = a + b;
                        ResultAndPressKey(result);
                        break;
                    case "2":
                        Version();
                        Console.WriteLine("Операция изваждане");
                        Console.WriteLine("------------------");
                        InputValues(out a, out b);
                        result = a - b;
                        ResultAndPressKey(result);
                        break;

                    case "3":
                        Version();
                        Console.WriteLine("Операция умножение");
                        Console.WriteLine("------------------");
                        InputValues(out a, out b);
                        result = a * b;
                        ResultAndPressKey(result);
                        break;

                    case "4":
                        Version();
                        Console.WriteLine("Операция деление");
                        Console.WriteLine("----------------");
                        InputValues(out a, out b);
                        result = a / b;
                        ResultAndPressKey(result);
                        break;
                    case "5":
                        Version();
                        Console.WriteLine("Изчисляване на корен квадратен");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine();
                        Console.Write("Изберете число: ");
                        a = double.Parse(Console.ReadLine());
                        result = Math.Sqrt(a);
                        ResultAndPressKey(result);
                        break;
                    case "6":
                        Version();
                        Console.WriteLine();
                        Console.WriteLine("Степенуване на число");
                        Console.WriteLine("--------------------");
                        Console.WriteLine();
                        Console.Write("Изберете число: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Изберете степен: ");
                        n = double.Parse(Console.ReadLine());
                        result = Math.Pow(a, n);
                        ResultAndPressKey(result);
                        break;
                    case "0":
                        repeat = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }

        private static void InputValues(out double a, out double b)
        {
            Console.WriteLine();
            Console.Write("Изберете първо число: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Изберете второ число: ");
            b = double.Parse(Console.ReadLine());
        }

        private static void ResultAndPressKey(double result)
        {
            Console.WriteLine();
            Console.WriteLine($"Резултат: {result}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Натиснете произволен клавиш, за да продължите");
            Console.ReadLine();
            Console.Clear();
        }

        private static void Version()
        {
            Console.Clear();
            Console.WriteLine(":: КОНЗОЛЕН КАЛКУЛАТОР :: VER 1.1 ::");
            Console.WriteLine();
        }
    }
}