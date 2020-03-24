using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Partial_classes_methods
{
    public partial class Person
    {
        partial void DoSomethingElse();

        public void DoSomething()
        {
            Console.WriteLine("Start");
            DoSomethingElse();
            Console.WriteLine("Finish");
        }


        public void Move()
        {
            Console.WriteLine("I am moving");
        }
    }
}
