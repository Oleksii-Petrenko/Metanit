using System;

namespace _021_System.Object
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person { Name = "Tom" };
            Person person2 = new Person { Name = "Bob" };
            Person person3 = new Person { Name = "Tom" };
            bool p1Ep2 = person1.Equals(person2);   // false
            bool p1Ep3 = person1.Equals(person3);   // true


        }
    }
    class Clock
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

    }

    class Person
    {
        public string Name { get; set; }
        public string Second { get; set; }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name) && String.IsNullOrEmpty(Second))
            {
                return base.ToString();
            }
            else
            {
                return $"Name: {Name} and Second: {Second}";
            }
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Person person = (Person)obj;
            return (this.Name == person.Name);


        }
    }
}
