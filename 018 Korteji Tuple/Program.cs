using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _018_Korteji_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (5, 10);
            (string, int, double, double) person = ("Tom", 25, 81.23, 81.23);
            Console.WriteLine(tuple.Item1); // 5
            Console.WriteLine(tuple.Item2); // 10
            tuple.Item1 += 26;
            Console.WriteLine(tuple.Item1); // 31
            Console.Read();

            var (name, age) = GetTuple(("Tom", 23), 12);
            Console.WriteLine(name);    // Tom
            Console.WriteLine(age);     // 35
            Console.Read();


        }
        private static (string name, int age) GetTuple((string n, int a) tuple, int x)
        {
            var result = (name: tuple.n, age: tuple.a + x);
            return result;
        }


    }
}
