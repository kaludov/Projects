using System;
namespace Example_SumOfArray
//Масиви - Сумиране на всички клетки от двумерен масив /матрица/
{
    class Example_SumOfArray
    {
        static void Main(string[] args)
        {
            //Задаване на стойности за двумерния масив
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            //Деклариране на променлива sum, за събиране стойностите от всяка клетка. Нулева начална стойност.
            int sum = 0;

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    sum += matrix[x, y];
                }
            }

            //Отпечатване резултатът от сумата
            Console.WriteLine($"Сумата от двумерният масив е {sum}");

        }
    }
}
