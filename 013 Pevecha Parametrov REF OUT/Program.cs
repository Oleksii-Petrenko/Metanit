using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Pevecha_Parametrov_REF_OUT
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 15;

            Addition(ref x, y);

            Console.WriteLine(x);
            Console.ReadKey();

            ///////////////////////////////////////////

            int a;
            
            Console.WriteLine($"Начальное значение переменной а= {a}");
            //Передача переменных по сылке
            //После выполнения этого кода по-прежнему a = 5, так как мы передали лишь ее копию
            IncrementalVal(ref a);
            Console.WriteLine($"Переменная a после передачи по значению равна = {a}");


            int b = 10;
            int d = 23;
            int c ;

            Sum(b, d, out x);

            Console.WriteLine(x);
            Console.ReadKey();

            int e = 1;
            int f = 2;
            int j;
            int h;


            GetData(e, f, out j, out h);

            Console.WriteLine(e);


        }

        static void Addition(ref int x, int y)
        {
            x += y;

        }


        // передача по сылке
        static void IncrementalVal(ref int x)
        {
            x++;
            Console.WriteLine($"Incremental: {x}");
        }

        static void Sum(int x, int y,out int a)
        {
            a = x + y;
        }
        static void GetData(int x, int y, out int area, out int perim)
        {
            // x = x + 10; нельзя изменить значение параметра x
            y = y + 10;
            area = x * y;
            perim = (x + y) * 2;
        }



    }
}
