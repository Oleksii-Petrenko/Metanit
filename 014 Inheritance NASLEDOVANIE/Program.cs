using System;

namespace _014_Inheritance_NASLEDOVANIE
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee tom = new Employee("Tom", "Microsoft");
            

        }


    }

    class Person
    {
        public string name;
        public int age;

        public Person()
        {
        }
        public Person(string name) : this(name, 18)
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Employee : Person
    {
        public string company;

        public Employee()
        {
        }
        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
        }
        public Employee(string name, string company) : base(name)
        {
            this.company = company;
        }
    }


}
