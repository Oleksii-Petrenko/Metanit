using System;

namespace _018_Sokritie
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bob = new Employee() {Name="Bob", SecondName="Robertson" };
            bob.Display();      // Bob Robertson

            Employee tom = new Employee();
            tom.Display();      // Tom Smith работает в Microsoft

            Console.ReadKey();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public string LastWorkCompany { get; set; }
        public new void Display()
        {
            Console.WriteLine($"Employee {Name}");
        }
    }
    class Manager : Employee
    {
        public string Class { get; set; }
        public string ClassSecondName { get; set; }
        public new void Display()
        {
            Console.WriteLine($"Manager {Name}");
        }
    }
}
