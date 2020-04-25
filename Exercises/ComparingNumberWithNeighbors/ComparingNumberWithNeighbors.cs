using System;
namespace ComparingNumberWithNeighbors
//Задача - Напишете метод, който проверява дали елемент, намиращ се на дадена позиция от масив е по-голям или малък от двата му съседа
{
    class ComparingNumberWithNeighbors
    {
        static void Main(string[] args)
        {
            //Въвеждане дължина на масива от конзолата
            Console.WriteLine("Въведете дължината на масива");
            int n = int.Parse(Console.ReadLine());

            //Дефиниране на масив array с въведената дължина
            int[] array = new int[n];

            //Създаване на FOR цикък за обхождане на масива и попълването му от конзола
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Въвеждане на търсен елемент
            Console.WriteLine("Изберете елемент от масива?");
            int number = int.Parse(Console.ReadLine());

            int z = array[number];

            int x = 0;
            int y = 0;

            if (number > 0)
            {
                x = array[number - 1];
            }
            if (number < array.Length - 1)
            {
                y = array[number + 1];
            }

            //Отпечатване на резултата в три варианта, в зависимост от стойността му
            if (z > x && z > y)
            {
                Console.WriteLine($"{number} е по-голям от неговите съседи");
            }
            else if (z < x && z < y)
            {
                Console.WriteLine($"{number} е по-малък от неговите съседи");
            }
            else
            {
                Console.WriteLine($"{number} има съседи с различна големина.");
            }

        }
    }
}
