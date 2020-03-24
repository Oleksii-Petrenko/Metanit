using System;

namespace _026_Delegate
{
   

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);

            account.RegisterHandler(new Account.AccountStateHandler(Show_Message));

            account.Withdraw(100);
            account.Withdraw(100);
            account.Withdraw(100);

            Console.ReadLine();

        }

        private static void Show_Message(string message)
        {
            Console.WriteLine(5);
        }



    }


    class Account
    {
        public delegate void AccountStateHandler(string message);

        AccountStateHandler _del;

        public void RegisterHandler(AccountStateHandler del)
        {
            _del = del;
        }


        int _sum;

        public Account(int sum)
        {
            _sum = sum;

        }

        public int CurentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
                if (_del != null)
                    _del($"Сумма {sum} снята со счета");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
            }
        }

    }
}
