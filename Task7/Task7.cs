using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class FindMinMaxIndices
    {
        public static void Task8(string[] args)
        {
            double[] array = new double[16];
            Console.WriteLine("Введите 16 вещественных чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!double.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"Индекс минимального элемента: {minIndex}");
            Console.WriteLine($"Индекс максимального элемента: {maxIndex}");
        }
    }
}
