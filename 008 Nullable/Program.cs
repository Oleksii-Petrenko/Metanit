using System;

namespace _008_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {


            int? z = null;
            bool? enable = null;

            Console.WriteLine(z.HasValue); 

            Console.WriteLine("Hello World!");
        }
    }
}
