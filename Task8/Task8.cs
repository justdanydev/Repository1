using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class ArrayDifferenceFromAverageLinq
    {
        public static void Task9(string[] args)
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

            double average = array.Average();
            double[] newArray = array.Select(x => x - average).ToArray();

            Console.WriteLine("Новый массив (разности):");
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
