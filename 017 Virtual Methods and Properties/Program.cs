using System;

namespace _017_Virtual_Methods_and_Properties
{
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
        public override void Display()
        {
            Console.WriteLine($"Manager {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Manager { Name = "Bob", Company = "Microsoft" };
            person.Display();
            Employee employee = (Employee)person;
            employee.Display();

            Console.ReadKey();
        }
    }
}
