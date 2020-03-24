using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Value_and_Reference_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { name = "Tom", age = 23 };

            ChangePerson(p);

            Console.WriteLine(p.name);
            Console.WriteLine(p.age);

            Console.Read();
        }

       

        struct Person
        {
            public string name;
            public int age;
        }

        static void ChangePerson(Person person)
        {
            person.name = "Alice";
            person.age = 99;

            person = new Person { name = "BOB", age = 77 };

        }


    }
}
