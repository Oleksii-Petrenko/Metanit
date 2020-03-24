using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////
            User Tom = new User();
            Tom.name = "Tom";
            Tom.age = 38;
            Tom.DisplayInfo();
            Console.ReadKey();


            User Bob = new User();
            int x = Bob.age;

            //////////////////////////////////////////
            User[] users = new User[3];
            
            users[0].age = 10;
            users[0].name = "Tom";
            users[0].DisplayInfo();


            users[1].age = 15;
            users[1].name = "Sem";
            users[1].DisplayInfo();

            users[2] = new User("Jery", 99);


            foreach (User user in users)
            {
                user.DisplayInfo();
            }
            ////////////////////////////////////////// 
            // Структуры - это значимые типы(value type), классы - ссылочные(reference type), поэтому они по разному используют память. Вследствие чего в каких-то ситуациях структуры являются более оптимальным решением для оптимизации производительности приложения. И в том же .NET есть немало встроенных структур, например, Point.
            // нельзя определить абстрактные структуры, нельзя использовать наследование структур и т.д.


            Console.ReadKey();

        }

        struct User
        {
            public string name;

            public int age;

            public User(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name : {name}, Age : {age}");
            }
            


        }






    }
}
