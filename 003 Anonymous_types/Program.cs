using System;

namespace _003_Anonymous_types
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new { Name = "Tom ", Age = 34 };
            var student = new { Name = "Alice ", Age = 21 };
            var manager = new { Name = "Bob", Age = 26, Company = "Microsoft" };

            Console.WriteLine(user.GetType().Name);
            Console.WriteLine(student.GetType().Name);
            Console.WriteLine(manager.GetType().Name);
            Console.WriteLine();

            User tom = new User { Name = "Tom" };

            int age = 34;

            var student1 = new { tom.Name, age };

            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.age);
            

            var people = new[]
            {
                new {Name="Tom"},
                new {Name="Bob"},
                new {Name="Soer"}
                
            };

            foreach (var p in people)
            {
                Console.WriteLine($"Next man name is '{p.Name}'");
            }

            Console.WriteLine();
        }

        class User
        {
            public string Name { get; set; }
        }



    }
}
