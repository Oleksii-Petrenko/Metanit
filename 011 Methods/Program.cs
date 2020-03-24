using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _011_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodBuy();
            Console.ReadKey();

            int sum = GetSum();
            string message = GetHello();


        }




        static void SayHello()
        {
            Console.WriteLine("Hello");


        }

        static void SayHelloLymda() => Console.WriteLine("Hello Lymbda");

        static void SayGoodBuy()
        {
            Console.WriteLine("Good Byu");
        }

        static void SayGoodBuyLumbda() => Console.WriteLine("Good Buy Lymbda");

        static string GetHello()
        {
            return "Hello Bitches";

        }

       

        static int GetSum()
        {
            int x = 2;
            int y = 3;
            int z = x + y;
            return z;
        }




    }
}
