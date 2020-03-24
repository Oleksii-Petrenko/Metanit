using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Property
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("axe");

            Console.ReadLine();

        }

        class Person
        {
            private string name;

            public Person(string _name)
            {
                name = _name;
            }


        }
        


    }
}
