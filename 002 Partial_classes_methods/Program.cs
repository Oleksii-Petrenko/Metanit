using System;

namespace _002_Partial_classes_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Move();
            p.Eat();

            Person tom = new Person();
            tom.DoSomething();



            Console.WriteLine("Hello World!");
        }
    }
}
