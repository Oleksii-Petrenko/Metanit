using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Arifmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Инкремент и дискремент
            // 2 Умножение и деление 
            // 3 Сложение и вычитание



            //double x = 10;
            //double z = x % 4;
            //double y = x * 5;

            //int a = 4;

            //int b=--a; //

            int a = 3;
            int b = 5;
            int c = 40;
            int d = c-- - b * a;
            // (c--) | - c=39 


            Console.WriteLine($"a={a} b={b} c ={c} d={d}");
            

           

            Console.ReadKey();
        }
    }
}
