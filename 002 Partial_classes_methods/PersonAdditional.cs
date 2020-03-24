using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Partial_classes_methods
{
    public partial class Person
    {
        partial void DoSomethingElse()
        {
            Console.WriteLine("I am reading a book"); 
        }
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }
    }
}
