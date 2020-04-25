using System;
namespace Example_JaggedConsoleInput
//Масиви - въвеждане на стойност от конзолата за Jagged масиви
{
    class Example_JaggedConsoleInput
    {
        static void Main(string[] args)
        {
            //Деклариране на jagged масив, с избран от конзолата брой редове
            Console.WriteLine("Колко реда желаете да има Jagget масива?");
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            //Въвеждане на числа от конзолата, чрез двоен FOR цикъл
            Console.WriteLine("Въведете желаните числа с интервал между тях.");

            for (int i = 0; i < jagged.Length; i++)
            {
                string inputNumbers = Console.ReadLine();

                //С методът Split определяме с какво да се разделят стойностите
                string[] numbersArray = inputNumbers.Split(' ');

                jagged[i] = new int[numbersArray.Length];

                for (int y = 0; y < jagged[i].Length; y++)
                {
                    jagged[i][y] = int.Parse(numbersArray[y]);
                }
            }


            //Отпечатване зададените стойности на Jagged масива
            Console.WriteLine();
            Console.WriteLine("Вашият Jagged масив:");

            foreach (var array in jagged)
            {
                foreach (var element in array)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }

        }
    }
}
