using System;
namespace Arrays
//Масиви
{
    class Arrays
    {
        static void Main(string[] args)
        {

            //Two Dimensional Array
            //=====================
            Console.WriteLine();
            Console.WriteLine("Two Dimensional Array");
            Console.WriteLine();

            //Дефиниране на двумерен масив matrixA с дефолтна стойност 0
            int[,] matrixA = new int[3, 4];

            //Дефиниране на двумерен масив matrixB с установени стойности
            int[,] matrixB =
            {
                {1,2,3,4},
                {5,6,7,8}
            };

            //Отпечатване на клетка от двумерен масив matrixA
            int element = matrixA[1, 3];
            Console.WriteLine(element);

            //Два вложени FOR цикъла за обхождане на двумерен масив
            //GetLenght(0) - задаване на измерение от многомерен масив
            for (int x = 0; x < matrixB.GetLength(0); x++)
            {
                for (int y = 0; y < matrixB.GetLength(1); y++)
                {
                    Console.Write(matrixB[x, y]);
                }
                Console.WriteLine();
            }

            //Jagged Array
            //============
            Console.WriteLine();
            Console.WriteLine("JaggedArray");
            Console.WriteLine();

            int[][] jaggedArray1;
            jaggedArray1 = new int[2][];
            jaggedArray1[0] = new int[5];
            jaggedArray1[1] = new int[9];



            int[][] jaggedArray2 =
            {
                new int[]{1,2,3},
                new int[]{-3,33,43,1,2},
                new int[]{5,6}

            };

            //Цикъл за обхождане на Jagget масив
            foreach (var array in jaggedArray2)
            {
                foreach (var unit in array)
                {
                    Console.Write($"{unit} ");
                }
                Console.WriteLine();
            }

        }
    }
}
