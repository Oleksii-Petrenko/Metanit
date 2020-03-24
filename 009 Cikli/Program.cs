using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 150; i++)
            { 
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");
                
            }


            Console.ReadKey();

            

            int i1 = 0;
            for (; i1 < 9;)
            {
                Console.WriteLine($"Квадрат числа {++i1} равен {i1 * i1}");
            }
            Console.ReadKey();

            int i2 = 6;
            do
            {
                Console.WriteLine(i2);
                i2--;
            } while (i2 > 0);
            Console.ReadKey();


            // Цикл while
            int i7 = 6;
            while (i7 > 0)
            {
                Console.WriteLine(i7);
                i7--;
            }


            // Операторы continue и break
            for (int i5 = 0; i5 < 9; i5++)
            {
                if (i5 == 5)
                    break;
                Console.WriteLine(i5);
            }


            for (int i6 = 0; i6 < 9; i6++)
            {
                if (i6 == 5)
                    continue;
                Console.WriteLine(i6);
            }

            Console.ReadKey();
        }
    }
}
