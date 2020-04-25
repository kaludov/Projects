using System;
namespace Example_PascalsTriangle
//Масиви - Триъгълника на Паскал
{
    class Example_PascalsTriangle
    {
        static void Main(string[] args)
        {
            //Въвеждаме височина на триъгълника
            Console.WriteLine("Каква е височината на триъгълника?");
            int height = int.Parse(Console.ReadLine());

            //Създаваме Jagged, с толкова масиви, колкото е въведената височина
            int[][] triangle = new int[height][];

            //Дефинираме променлива currWidth, с единица за първия ред
            int currWidth = 1;

            //Създаваме FOR цикъл, който да увеличава с единица всеки ред от триъгълника
            for (int row = 0; row < height; row++)
            {
                triangle[row] = new int[currWidth];
                int[] currRow = triangle[row];
                currRow[0] = 1;
                currRow[currRow.Length - 1] = 1;

                currWidth++;
                //След първите два реда, стойностите са > 1
                if (currRow.Length > 2)
                {
                    for (int i = 1; i < currRow.Length - 1; i++)
                    {
                        int[] prevRow = triangle[row - 1];
                        int prevRowSum = prevRow[i] + prevRow[i - 1];
                        currRow[i] = prevRowSum;

                    }
                }
            }

            //Отпечатваме резултата
            for (int row = 0; row < height; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));

                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }

        }
    }
}
