using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Preobrazovanie_tipov
{
    class Program
    {
        static void Main(string[] args)
        {


            byte a = 4;
            byte b = (byte)(a + 70);  // 4 байт - 1 байт - сужающее преобразование

            // неявное расширение 
            // byte -> short -> int -> long -> decimal
            // byte -> short -> int -> double 
            // byte -> short -> float -> double
            // char -> int

            double d1 = 33.0;
            decimal d2 = (decimal)d1;



            int c = 33;
            int d = 600;

            byte e = (byte)(c + d);




            Console.WriteLine(e);

             

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
