using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massivi
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
            nums[3] = 3;
            nums[4] = 4;

            Console.WriteLine(nums[3]);


            // Перебор масивов

            int[] numbers7 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12 };
            foreach (object i in numbers7)
            {
                Console.WriteLine(i);
            }



        }
    }
}
