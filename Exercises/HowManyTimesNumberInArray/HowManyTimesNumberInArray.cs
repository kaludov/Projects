using System;
namespace HowManyTimesNumberInArray
//Задача - Напишете метод, който намира колко пъти дадено число се среща в даден масив
{
    class HowManyTimesNumberInArray
    {
        static void Main(string[] args)
        {
            //Въвеждане дължина на масива от конзолата
            Console.WriteLine("Въведете дължината на масива");
            int n = int.Parse(Console.ReadLine());

            //Дефиниране на масив array с въведената дължина
            int[] array = new int[n];

            //Въвеждане на търсено число
            Console.WriteLine("Кое е търсеното число?");
            int number = int.Parse(Console.ReadLine());

            //Създаване на FOR цикък за обхождане на масива и попълването му от конзола
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            //Дефиниране на нулева променлива x
            int x = 0;

            //Създаване на FOREACH цикъл за обхождане на масива и допълването на X, спрямо съвпаденията
            foreach (var element in array)
            {
                if (number == element)
                {
                    x++;
                }
            }

            //Отпечатване на резултата в три варианта, в зависимост от стойността му
            if (x == 0)
            {
                Console.WriteLine($"Числото {number} не присъства нито веднъж във вашия масив.");
            }
            else if (x == 1)
            {
                Console.WriteLine($"Числото {number} присъства {x} път във вашия масив.");
            }
            else
            {
                Console.WriteLine($"Числото {number} присъства {x} пъти във вашия масив.");
            }

        }
    }
}
