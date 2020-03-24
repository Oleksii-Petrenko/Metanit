using System;

namespace _006_Deconstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Tom", Age = 35 };

            (string name, int age) = person;

            Console.WriteLine(name);

            Console.WriteLine(age);

            Console.WriteLine();

            Person perso = new Person { Name = "Tom", Age = 33 };

            string nam;
            int ag;
            perso.Deconstruct(out name, out age);


        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out string name, out int age)
        {
            name = this.Name;
            age = this.Age;
        }



    }
}
