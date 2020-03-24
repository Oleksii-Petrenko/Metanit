using System;

namespace _015_Preobrazovanie_tipov
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("Tom", "Microsoft");

            Person person = employee;

            

            Person person2 = new Client("Bob", "ContosoBank");

            Client client1 = (Client)person2;


            object person11 = new Employee("Tom", "Microsoft");  // от Employee к object
            object person22 = new Client("Bob", "ContosoBank");  // от Client к object
            object person33 = new Person("Sam");                 // от Person к object

            object obj = new Employee("Bill", "Microsoft");


            // Объект Employee также представляет тип object
            object obj111 = new Employee("Bill", "Microsoft");
            


            // чтобы обратиться к возможностям типа Employee, приводим объект к типу Employee
            Employee emp = (Employee)obj111;
            
            
            // объект Client также представляет тип Person
            Person person111 = new Client("Sam", "ContosoBank");

            

            // преобразование от типа Person к Client
            Client client = (Client)person111;

            Console.WriteLine(person.Name);
            Console.ReadKey();

        }
    }



    class Person
    { 
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            
            Console.WriteLine($"Person {Name}");

        }



    }



    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }


    }

    class Client : Person
    {
        public string Bank { get; set; }
        public Client (string name , string bank) : base(name)
        {
            Bank = bank;
        }

    }


}
