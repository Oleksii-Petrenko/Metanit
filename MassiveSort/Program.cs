using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter value
            int[] nums = new int[7];
            Console.WriteLine("Enter seven nambers");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-number : ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());


            }

            // Sort
            int temp;
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            // Show
            Console.WriteLine("Show sort missive value");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();




        }
    }
}
