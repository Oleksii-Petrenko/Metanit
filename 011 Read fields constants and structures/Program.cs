using System;

namespace _011_Read_fields_constants_and_structures
{
    class Program
    {
        static void Main(string[] args)
        {

            


            Console.WriteLine(MathLib.PI);
            Console.ReadKey();
        }
    }

    class MathLib
    {
        public readonly double K;

        public MathLib(double k)
        {
            K = k;
        }


        public const double PI = 3.14;
        public const double e = 2.71;

        

    }

    struct User
    {
        public readonly string name;

        public readonly int age;

        public User(string name)
        {
            this.name = name;
        }
    }

}
