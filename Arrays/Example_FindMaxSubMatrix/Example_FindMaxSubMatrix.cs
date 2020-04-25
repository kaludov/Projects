using System;
namespace Example_FindMaxSubMatrix
//Масиви - Максимална площадка в матрица
{
    class Example_FindMaxSubMatrix
    {
        static void Main(string[] args)
        {
            //Задаване на стойности за двумерния масив
            int[,] matrix =
            {
                { 12, 4, -13, 42, 555,9 },
                { 4,12, 201, -3, 54,1 },
                { 33, 8, -9,422,32,999 },
                {-123, 23, 19,22,32,0 },
                {2, 142, 423,643,62,-54 }
            };

            //Деклариране на променлива sum, за събиране стойностите от всяка клетка.
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            //Създаване на двоен FOR цикъл, за обходжане на матрицата
            //На GetLenght се добавя '-1', за да се избегнат последните редове и колони
            for (int x = 0; x < matrix.GetLength(0) - 1; x++)
            {
                for (int y = 0; y < matrix.GetLength(1) - 1; y++)
                {

                    //Деклариране на променлива sum, която събира текущи четири съседни клетки
                    int sum = matrix[x, y] + matrix[x, y + 1] + matrix[x + 1, y] + matrix[x + 1, y + 1];

                    //Условие за запис на текущите стойности в best променливите, само ако са по-големи от тях
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = x;
                        bestCol = y;
                    }
                }
            }

            //Отпечатване на съседни четири клетки с най-голяма сума, както и техният сбор
            Console.WriteLine("Четирите съседни клетки с най-висока стойност са:");

            Console.WriteLine($"{matrix[bestRow, bestCol]}, {matrix[bestRow, bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]}, {matrix[bestRow + 1, bestCol + 1]}");

            Console.WriteLine($"Сумата от тях е {bestSum}");

        }
    }
}
