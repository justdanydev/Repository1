using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class SortArrayAndSumMinMax
    {
        public static void Task12(string[] args)
        {
            double[] array = new double[12];
            Console.WriteLine("Введите 12 вещественных чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!double.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }


            Array.Sort(array);
            Array.Reverse(array);


            double sumMinMax = array[0] + array[array.Length - 1];

            Console.WriteLine("Отсортированный массив (по убыванию):");
            Console.WriteLine(string.Join(" ", array));
            Console.WriteLine($"Сумма максимального и минимального элементов: {sumMinMax}");
        }
    }
}
