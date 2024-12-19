using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SwapMaxAndFirstLinq
    {
        public static void Task5(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine("Введите 10 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            int maxVal = array.Max();
            int maxIndex = Array.IndexOf(array, maxVal);

            int temp = array[0];
            array[0] = maxVal;
            array[maxIndex] = temp;

            Console.WriteLine("Массив после обмена:");
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
