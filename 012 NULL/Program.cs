using System;

namespace _012_NULL
{
    class Program
    {
        static void Main(string[] args)
        {

            object o = null;
            string s = null;

            object x = null;
            object y = x ?? 100; // // равно 100, так как x равен null

            object z = 200;
            object t = z ?? 44;

            User user = new User();
            Console.WriteLine(user.Phone.Company.Name);

            if (user!=null)
            {
                if (user.Phone!=null)
                {
                    if (user.Phone.Company!=null)
                    {
                        string compranyName = user.Phone.Company.Name;
                        Console.WriteLine(compranyName);
                    }

                }

            }

            if (user != null && user.Phone != null && user.Phone.Company != null)

            {
                string companyName2 = user.Phone.Company.Name;
                Console.WriteLine(companyName2);

            }

            string companyName3 = user?.Phone?.Company?.Name ?? "no value";
            Console.WriteLine(companyName3);

            Console.WriteLine($"x = {t};");
            Console.ReadKey();

        }
    }

    class User
    {
        public Phone Phone { get; set; }
    }



    class Phone
    {
        public Company Company { get; set; }
    }




    class Company
    {
        public string Name { get; set; }

    }






}
