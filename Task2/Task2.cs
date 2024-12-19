using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ArrayAverageReplacementLinq
    {
        public static void Task2(string[] args)
        {
            int[] array = new int[12];
            Console.WriteLine("Введите 12 целых чисел:");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте ещё раз:");
                }
            }

            double average = array.Average();

            int[] newArray = array.ToArray();
            newArray[4] = (int)average;

            Console.WriteLine("Новый массив:");
            Console.WriteLine(string.Join(" ", newArray));
        }
    }

}
