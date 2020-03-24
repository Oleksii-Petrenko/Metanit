using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Massivi
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers;

            int[] nums1 = new int[4];

            int[] nums2 = new int[4] { 1, 2, 3, 5 };

            int[] nums3 = new int[] { 1, 2, 3, 5 };

            int[] nums4 = new[] { 1, 2, 3, 5 };

            int[] nums5 = { 1, 2, 3, 5 };

            int[] nums = new int[4];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;

            Console.WriteLine(nums[3]);


            // Перебор масивов

            int[] numbers7 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12 };
            foreach (object i in numbers7)
            {
                Console.WriteLine(i);
            }

            // Перебор масива через его длину 
            int[] numbers8 = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers8.Length; i++)
            {
                Console.WriteLine(numbers8[i]);
            }
            Console.WriteLine("****************************************************************************");
            int[] numbers9 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < numbers9.Length; i++)
            {
                numbers9[i] = numbers9[i] * 2;
                Console.WriteLine(numbers9[i]);
            }

            Console.ReadKey();

            // Многомерные массивы

            int[,] nums100;
            int[,] nums20 = new int[2, 3];
            int[,] nums30 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums40 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums50 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums60 = { { 0, 1, 2 }, { 3, 4, 5 } };

            int[,,] nums33 = new int[2, 3, 4];

            int [,] ms = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            foreach (int i in ms)
            
                Console.WriteLine($@"{i}");
            
            Console.WriteLine("****************************************************************************");

            Console.ReadKey();
            {
                int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

                int rows = mas.GetUpperBound(0) + 1;
                int columns = mas.Length / rows;
                // или так
                // int columns = mas.GetUpperBound(1) + 1;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write($"{mas[i, j]} \t");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();

            // Найдем количество положительных чисел в массиве:
            {

                int[] numbers22 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
                int result = 0;
                foreach (int number in numbers22)
                {
                    if (number > 0)
                    {
                        result++;
                    }
                }
                Console.WriteLine($"Число элементов больше нуля: {result}");

            }

            //  Вторая задача - инверсия массива, то есть переворот его в обратном порядке:

            {

                int[] numbers333 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

                int n = numbers333.Length; // длина массива
                int k = n / 2;          // середина массива
                int temp1;               // вспомогательный элемент для обмена значениями
                for (int i = 0; i < k; i++)
                {
                    temp1 = numbers333[i];
                    numbers333[i] = numbers333[n - i - 1];
                    numbers333[n - i - 1] = temp1;
                }
                foreach (int i in numbers333)
                {
                    Console.Write($"{i} \t");
                }

            }





        }
    }
}
