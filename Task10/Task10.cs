using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class EvenPositiveCounterLinq
    {
        public static void Task11(string[] args)
        {
            int[] array = new int[14];
            Console.WriteLine("Введите 14 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            int evenPositiveCount = array.Count(x => x > 0 && x % 2 == 0);
            int evenPositiveSum = array.Where(x => x > 0 && x % 2 == 0).Sum();

            Console.WriteLine($"Количество четных положительных элементов: {evenPositiveCount}");
            Console.WriteLine($"Сумма четных положительных элементов: {evenPositiveSum}");
        }
    }
}
