using System;

namespace _004_Local_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetResult(new int[] { -3, -2, -1, 0, 1, 2, 3, 4, 5, 6 });
            Console.WriteLine(result);

            Console.WriteLine();
            Console.WriteLine("Hello World!");

        }


        static int GetResult(int[] numbers)
        {
            int limit = 2;
            // local function

            bool IsMoreThan(int number)
            {
                return number > limit;
            }

            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsMoreThan(numbers[i]))
                {
                    result += numbers[i];
                }

            }
            return result;

        }


    }

}
