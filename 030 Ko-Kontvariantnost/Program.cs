using System;

namespace _030_Ko_Kontvariantnost
{
    class Program
    {
        delegate Person PersonFactory(string name);
        static void Main(string[] args)
        {
            PersonFactory personDel;

            personDel = BuildClient; // ковариантность

            Person p = personDel("Tom");

            Console.WriteLine(p.Name);

            Console.ReadLine();
        }

        private static Client BuildClient(string name)
        {
            return new Client { Name = name };
        }


        class Person
        {
            public string Name { get; set; }
        }

        class Client: Person
        {

        }

    }
}
