using System;

namespace _029_Events
{
    class Program
    {
      

        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;
            acc.Put(50);
            acc.Take(100);
            acc.Take(250);
            Console.Read();
        }

        private static void DisplayMessage(object sender, AccountEventArgs e)
        {
            Console.WriteLine($"Сумма транзакции: {e.Sum}");
            Console.WriteLine(e.Message);
        }

    }
    #region Account old 
    //class Account
    //{
    //    public delegate void AccountHandler(string message);
    //    public event AccountHandler Notify;              // 1.Определение события
    //    public Account(int sum)
    //    {
    //        Sum = sum;
    //    }
    //    public int Sum { get; private set; }
    //    public void Put(int sum)
    //    {
    //        Sum += sum;
    //        Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
    //    }
    //    public void Take(int sum)
    //    {
    //        if (Sum >= sum)
    //        {
    //            Sum -= sum;
    //            Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
    //        }
    //        else
    //        {
    //            Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
    //        }
    //    }
    //}
    #endregion

    class Account
    {
        public delegate void AccountHandler(object sender, AccountEventArgs e);
        public event AccountHandler Notify;
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
            }
            else
            {
                Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum)); 
            }
        }
    }
    class AccountEventArgs
    {
        // Сообщение
        public string Message { get; }
        // Сумма, на которую изменился счет
        public int Sum { get; }

        public AccountEventArgs(string mes, int sum)
        {
            Message = mes;
            Sum = sum;
        }
    }

}
