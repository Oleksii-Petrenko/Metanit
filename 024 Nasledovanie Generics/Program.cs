using System;

namespace _024_Nasledovanie_Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Account<string> acc1 = new Account<string>("34");
            Account<int> acc3 = new UniversalAccount<int>(45);
            UniversalAccount<int> acc2 = new UniversalAccount<int>(33);
            StringAccount acc4 = new StringAccount("438767");
            IntAccount<string> acc7 = new IntAccount<string>(5) { Code = "r4556" };
            Account<int> acc8 = new IntAccount<long>(7) { Code = 4587 };
            Console.WriteLine(acc7.Id);
            Console.WriteLine(acc8.Id);


            MixedAccount<string, int> acc9 = new MixedAccount<string, int>("456") { Code = 356 };
            Account<string> acc10 = new MixedAccount<string, int>("9867") { Code = 35678 };
            
            Console.WriteLine((MixedAccount<string, int>)acc10.mixacc);
            Console.WriteLine(((MixedAccount<string, int>)acc10).mixacc);

        }
    }
    class Account<T>
    {
        public T Id { get; set; }
        public Account(T _id)
        {
            Id = _id;
        }



    }

    class MixedAccount<T, K> : Account<T>
    where K : struct
    {
        public int mixacc = 12;
        public K Code { get; set; }
        public MixedAccount(T id) : base(id)
        {

        }
    }


    class UniversalAccount<T> : Account<T>
    {
        public UniversalAccount(T id) : base(id)
        {

        }
    }
    class StringAccount : Account<string>
    {
        public StringAccount(string id) : base(id)
        {

        }

    }
    class IntAccount<T> : Account<int>
    {
        public T Code { get; set; }
        public IntAccount(int id) : base(id)
        {
        }
    }
}
