using System;

namespace _005_PatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Manager(); //Employee();
            // Какой бы ты предрпочел из вариантов ?

            UseEmployee(emp);
            UseEmployee2(emp);

            UseEmployee3(emp);
            UseEmployee4(emp);
            UseEmployee5(emp);

            Console.Read();


            
        }


        class Employee
        {
            public virtual void Work()
            {
                Console.WriteLine("Yes I am working");

            }



        }

        class Manager : Employee
        {
            public override void Work()
            {
                Console.WriteLine("Its Ok. Going work.");
            }

            public bool IsOnVacation { get; set; }

        }

        static void UseEmployee(Employee emp)
        {
            Manager manager = emp as Manager;
            if (manager !=null && manager.IsOnVacation == false)
            {
                manager.Work();
            }
            else
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
        }

        static void UseEmployee2(Employee emp)
        {
            try
            {
                Manager manager = (Manager)emp;
                if (!manager.IsOnVacation)
                {
                    manager.Work();
                }

            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        static void UseEmployee3(Employee emp)
        {
            if (emp is Manager)
            {
                Manager manager = (Manager)emp;
                if (!manager.IsOnVacation)
                {
                    manager.Work();
                }
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }

        }

        static void UseEmployee4 (Employee emp)
        {
            if (emp is Manager manager && manager.IsOnVacation == false)
            {

                if (!(emp is null))
                {
                    emp.Work();
                }

            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }


        }

        static void UseEmployee5(Employee emp)
        {
            switch (emp)
            {
                case Manager manager when manager.IsOnVacation == false:
                    manager.Work();
                    break;
                case null:
                    Console.WriteLine("Объект не задан");
                    break;
                default:
                    Console.WriteLine("Объект не менеджер");
                    break;
            }
        }


    }


}
