using System;

namespace _022_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount<int> acc1 = new Acount<int>() {Sum=5000};
            Acount<int> acc2 = new Acount<int>() { Sum = 6000 };

            Transaction<Acount<int>, string> transaction1 = new Transaction<Acount<int>, string>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Code = "sdfsdfsdf",
                Sum = 1000
            };

            int x = 7;
            int y = 10;
            Console.WriteLine($"x = {x}, y={y}");
            Swap<int>(ref x, ref y);

            Console.WriteLine($"x = {x}, y={y}");
            

        }
       public static void Swap<T> (ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
            
        }

    }

    class Acount<T>
    {
        public T session = default(T);
        public T Id { get; set; }
        public int Sum { get; set; }
    }

    class Transaction<U,V>
    {
        public U FromAccount { get; set; }
        public U ToAccount { get; set; }
        public V Code { get; set; }
        public int Sum { get; set; }
        
    }


}
