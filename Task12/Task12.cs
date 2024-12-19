using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public class SumAndDifferenceMinMax
    {
        public static void Task13(string[] args)
        {
            int[] array = new int[15];
            Console.WriteLine("Введите 15 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            int minVal = array.Min();
            int maxVal = array.Max();


            int sumMinMax = maxVal + minVal;
            int diffMinMax = maxVal - minVal;

            Console.WriteLine($"Минимальный элемент: {minVal}");
            Console.WriteLine($"Максимальный элемент: {maxVal}");
            Console.WriteLine($"Сумма максимального и минимального элементов: {sumMinMax}");
            Console.WriteLine($"Разность максимального и минимального элементов: {diffMinMax}");
        }
    }
}
