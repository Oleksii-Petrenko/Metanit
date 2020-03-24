using System;

namespace _013_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {

            People people = new People();
            people[0] = new Person { Name = "Tom" };
            people[1] = new Person { Name = "Bob" };
            people[2] = new Person { Name = "Bill" };
            people[3] = new Person { Name = "Jonh" };
            people[4] = new Person { Name = "Anna" };
            people[5] = new Person { Name = "Djuna" };
            people[6] = new Person { Name = "Soyer" };

            
            Person a = people[1];

            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "Hello, World";
            Console.WriteLine(stringCollection[0]);


            Console.WriteLine(a);
            Console.WriteLine(people[1]);
            Console.ReadKey();

        }
    }

    class Person
    {
        public string Name { get; set; }
    }

    class People 
    {
        Person[] data;

        public People()
        {
            data = new Person[7];
        }

        public Person this[int index]
        {
            get
            {
                return data[index];

            }
            set
            {
                data[index] = value;
            }
        }
    }
    class SampleCollection<T>
    {
        // Declare an array to store the data elements.
        private T[] arr = new T[100];

        // Define the indexer to allow client code to use [] notation.
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }

}
