using System;

namespace _023_Ogranicheniya_generics
{
    class Program
    {
        #region
        //    В качестве ограничений мы можем использовать следующие типы:

        //    Классы

        //    Интерфейсы

        //    class - универсальный параметр должен представлять класс

        //    struct - универсальный параметр должен представлять структуру

        //    new() - универсальный параметр должен представлять тип, который имеет общедоступный(public) конструктор без параметров
       
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // 
        //      Если для универсального параметра задано несколько ограничений, то они должны идти в определенном порядке:
    
        //      Название класса, class, struct. Причем мы можем одновременно определить только одно из этих ограничений

        //      Название интерфейса

        //          new()



        #endregion

        private static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>(1857) { Sum = 4500 };
            Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

            

            Transaction<Account<int>> transaction1 = new Transaction<Account<int>>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 900
            };
                        
            transaction1.Execute();

            Console.Read();

            Account<int> acc3 = new Account<int>(1857) { Sum = 4500 };
            Account<int> acc4 = new Account<int>(3453) { Sum = 5000 };

            Transact<Account<int>>(acc3, acc4, 900);

            Console.Read();

        }
        public static void Transact<T>(T acc1, T acc2, int sum) where T : Account<int>
        {
            if (acc1.Sum > sum)
            {
                acc1.Sum -= sum;
                acc2.Sum += sum;
            }
            Console.WriteLine($"acc1: {acc1.Sum}   acc2: {acc2.Sum}");
        }
    }
    class Account<T>
    {
        public T Id { get; private set; } // номер счета
        public int Sum { get; set; }
        public Account(T _id)
        {
            Id = _id;
        }
    }
    class Transaction<T> where T : Account<int>
    {
       

        public T FromAccount { get; set; }  // с какого счета перевод
        public T ToAccount { get; set; }    // на какой счет перевод
        public int Sum { get; set; }        // сумма перевода

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }

    interface IAccount
    {
        int CurrentSum { get; set; }
    }
    class PersonOne
    {
        public string Name { get; set; }
    }

    class TransactionUnic<T> where T : PersonOne, IAccount, new()
    {

    }


}
