using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class CountElementsAboveAverage
    {
        public static void Task3(string[] args)
        {
            int[] array = new int[11];
            Console.WriteLine("Введите 11 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > average)
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество элементов с абсолютным значением больше среднего арифметического: {count}");
        }
    }
}
