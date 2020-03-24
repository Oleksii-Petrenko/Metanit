using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Parametri_Metodov
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int c;

            int summ = Summ(1, 6);
            Console.WriteLine(summ);
            Console.ReadKey();
             
            int summ_01 = Summ(5 + 3 + a, b - 5);   // передача сложного выражения 
            Console.WriteLine(summ_01);
            Console.ReadKey();

            // Summ(a, c);  // Нескомпилируеться 

            Display("Alex", 12);

            OptionalParam(a, b);
            OptionalParam(a, b, Summ(1, 2), Summ(a,100));
            
        }

        static int Summ(int x, int y)
        {
            return x + y;
        }

        static void Display(string name, int age)
        {
            Console.WriteLine($"Name:{name} Age:{age}");
        }

        static int OptionalParam(int x, int y, int z=5, int s=4)  // Необезательные параметры
        {
            return x + y + z + s;
        }


    }


}
