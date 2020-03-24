using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Static_members_and_static_modifier
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Account.bonus);
            Account.bonus += 200;

            Account account1 = new Account(150);
            Console.WriteLine(account1.totalSum);

            Account account2 = new Account(1000);
            Console.WriteLine(account2.totalSum);

            Console.ReadKey();

            User user1 = new User();
            User user2 = new User();
            User user3 = new User();
            User user4 = new User();
            User user5 = new User();
            User user6 = new User();
            User user7 = new User();
            User user8 = new User();
            User user9 = new User();
            User user10 = new User();

            

            User.DisplayCounter();
            Console.ReadKey();
        }

        class Account
        {
            public static decimal bonus = 100;

            public decimal totalSum;


            public Account(decimal sum)
            {
                totalSum = totalSum + bonus;

            }

            PublicAccount Acc = new PublicAccount(100, 10);




        }
        class PublicAccount
        {


            public PublicAccount(decimal sum, decimal rate)
            {
                if (sum < minSum)
                {
                    throw new Exception("недопустимая сумма");
                }
            }
            private static decimal minSum = 100;  // минимально допустимая сумма на счете для всех счетов 

            public static decimal MinSum
            {
                get { return minSum; }
                set { if (value > 0) minSum = value; }

            }

            public decimal Sum { get; private set; }  // сумма на счете 
            public decimal Rate { get; private set; } // процентная ставка 

            // подсчет суммы на счете через определенный период по определеной ставке 

            public static decimal GetSum(decimal sum, decimal rate, int period)
            {
                decimal result = sum;
                for (int i = 1; i <= period; i++)

                    result = result + result * rate / 100;

                return result;


            }


        }


        class User
        {

            public static int counter = 0;

            public User()
            {
                counter++;
            }

            public static void DisplayCounter()
            {
                Console.WriteLine($"Создано {counter} обьектов User");
            }


        }


    }
}
