using System;

namespace _027_Anonimus_methods
{
    class Program
    {
        delegate int Operation(int x, int y);
        delegate void MessageHandler(string message);
        static void Main(string[] args)
        {
            MessageHandler handler = delegate (string mes)
            {
                Console.WriteLine(mes);
            };

            handler("Hello Words");
            handler("_____________________________________________________________________");


            ShowMessage("Hello", delegate (string mes)
            {
                Console.WriteLine(mes);
            });

            int z = 4;


            Operation operation = delegate (int x, int y)
            {
                return x + y + z;
            };



            int d = operation(6, 10);
            Console.WriteLine(d);
            Console.ReadKey();



        }
        static void ShowMessage(string mes, MessageHandler handler)
        {
            handler(mes);
        }


    }
}
