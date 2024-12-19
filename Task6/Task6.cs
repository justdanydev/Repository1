using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class EvenOddCounterLinq
    {
        public static void Task7(string[] args)
        {
            int[] array = new int[20];
            Console.WriteLine("Введите 20 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            int evenCount = array.Count(x => x % 2 == 0);
            int oddCount = array.Count(x => x % 2 != 0);

            Console.WriteLine($"Количество четных чисел: {evenCount}");
            Console.WriteLine($"Количество нечетных чисел: {oddCount}");

            string result = evenCount > oddCount ? "Четных чисел больше." : (oddCount > evenCount ? "Нечетных чисел больше." : "Количество четных и нечетных чисел одинаково.");
            Console.WriteLine(result);
        }
    }
}
