using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    public class ReplaceMultiplesOfThree
    {
        public static void Task14(string[] args)
        {
            int[] array = new int[17];
            Console.WriteLine("Введите 17 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            int sumOfOdds = array.Where(x => x % 2 != 0).Sum();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    array[i] = sumOfOdds;
                }
            }

            Console.WriteLine("Измененный массив:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
