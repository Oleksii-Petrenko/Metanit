using System;

namespace _005_Interface_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    interface IAction
    {
        void Move();
    }
    interface IRunAction : IAction
    {
        void Run();
    }
    class BaseAction : IRunAction
    {
        public void Move()
        {
            Console.WriteLine("Move");
        }
        public void Run()
        {
            Console.WriteLine("Run");
        }
    }
}
