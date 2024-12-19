using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class EvenNumbersCounter
    {
        public static void Task1(string[] args)
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


            int evenCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine($"Количество четных чисел: {evenCount}");
        }
    }


}
