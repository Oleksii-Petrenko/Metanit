using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Method_PARAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition(1, 2, 3, 4, 5, 6, 7, 8);

            int[] Array = { 1, 5, 7, 9, 0, -5, -144 };

            Addition(Array);

            Candidate candidate = new Candidate();

            int age = 20;

            string name = "Alex";

            candidate.Age = age;

            candidate.Name = name;

            AdditionWithOtherParams(candidate.Name, candidate.Age, Array);


        }



        static void Addition(params int[] integers)
        {
            int result = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                result += integers[i];
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void AdditionWithOtherParams(string message, int age, params int[] array)
        {
            int result = 0;

            for (int i = 1; i < array.Length; i++)
            {
                result += array[i];
                
            }

            Console.WriteLine($"Зовут кандидата {message}. Возраст кандидата {age}, количество опты на разных работах {result}");
            Console.ReadKey();
            
        }

        public class Candidate
        {
            public int Age { get; set; }

            public string Name { get; set; }

        }
    }
        

}
