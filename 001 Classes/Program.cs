using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();          // вызов 1-ого конструктора без параметров
            Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
            Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами


            bob.GetInfo();          // Имя: Bob  Возраст: 18
            tom.GetInfo();          // Имя: Неизвестно  Возраст: 18
            sam.GetInfo();          // Имя: Sam  Возраст: 25
            Console.ReadKey();

          

        }


    }
}
