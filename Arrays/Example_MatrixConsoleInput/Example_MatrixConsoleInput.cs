using System;
namespace Example_MatixConsoleInput
//Масиви - въвеждане на стойност от конзолата за двумерен масив /матрица/
{
    class Example_MatixConsoleInput
    {
        static void Main(string[] args)
        {
            //Създаване на матрица с входни данни от конзола
            //Въвеждаме брой редове и колони
            Console.WriteLine("Създаване на матрица.");
            Console.Write("Въведете брой редове:");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Въведете брой колони:");
            int cols = int.Parse(Console.ReadLine());

            //Деклариране на двумерен масив със зададените стойности
            int[,] matrix = new int[rows, cols];


            //Създаване на двоен FOR цикъл, за въвеждане стойност на всяка клетка
            Console.WriteLine($"Създадохте матрица с {rows} реда и {cols} колони");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.WriteLine($"Въведете стойност за клетка {row},{col}");
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            //Създаване на двоен FOR цикъл за отпечатването на всяка клетка
            Console.WriteLine("Въвеждането на данни приключи.");
            Console.WriteLine("Вашата матрицата:");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
