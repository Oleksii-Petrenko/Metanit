using System;
using System.Reflection;

namespace Atribute_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("Hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);

            var attributes = type.GetCustomAttributes();

            var attributes2 = type.GetCustomAttributes(false);

            foreach (var item in attributes2)
            {
                Console.WriteLine(item);
            }

            var property = type.GetProperties();



            foreach (var prop in property)
            {
                Console.WriteLine(prop.PropertyType +" "+ prop.Name + " " + prop.Attributes );

                var attrs = prop.GetCustomAttributes(false);

                foreach (var a in attrs)
                {
                    Console.WriteLine(a);
                }
            }



            Console.ReadLine();
            //TODO : 55:20



        }
    }
}
