using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class SwapMinMaxLinq
    {
        public static void Task6(string[] args)
        {
            int[] array = new int[9];
            Console.WriteLine("Введите 9 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            int minVal = array.Min();
            int minIndex = Array.IndexOf(array, minVal);
            int maxVal = array.Max();
            int maxIndex = Array.IndexOf(array, maxVal);


            int temp = array[minIndex];
            array[minIndex] = array[maxIndex];
            array[maxIndex] = temp;

            Console.WriteLine("Массив после обмена:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
