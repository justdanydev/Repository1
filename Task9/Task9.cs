using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    public class SumOfElementsAboveAverage
    {
        public static void Task10(string[] args)
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

            double averageOfNegativeModules = 0;
            int negativeCount = 0;
            double sumOfNegativeModules = 0;

            foreach (int num in array)
            {
                if (num < 0)
                {
                    sumOfNegativeModules += Math.Abs(num);
                    negativeCount++;
                }
            }

            if (negativeCount > 0)
            {
                averageOfNegativeModules = sumOfNegativeModules / negativeCount;
            }
            else
            {
                Console.WriteLine("В массиве нет отрицательных чисел. Сумма не может быть вычислена.");
                return;
            }


            double sum = 0;
            foreach (int num in array)
            {
                if (Math.Abs(num) > averageOfNegativeModules)
                {
                    sum += num;
                }
            }

            Console.WriteLine($"Среднее арифметическое модулей отрицательных элементов: {averageOfNegativeModules}");
            Console.WriteLine($"Сумма элементов с абсолютным значением больше среднего: {sum}");
        }
    }
}
