using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Uslownie_Virajeniya
{
    class Program
    {
        static void Main(string[] args)
        {
            {//    ==   

                int a = 10;
                int b = 4;

                bool c = a == b;

                Console.WriteLine(c);
                Console.WriteLine("________________________________________________");
                Console.ReadKey();



            }

            {//    !=    

                int a = 10;
                int b = 4;

                bool c = a != b;
                bool d = a != 10;

                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine("________________________________________________");
                Console.ReadKey();
                
            }
            {//    <    

                int a = 10;
                int b = 4;

                bool c = a < b; // false
                
                Console.WriteLine(c);
                Console.WriteLine("________________________________________________");
                Console.ReadKey();

            }
            {//    >    

                int a = 10;
                int b = 4;

                bool c = a > b; // true 
                bool d = a > 25; // fasle

                Console.WriteLine(c);
                Console.WriteLine("________________________________________________");
                Console.ReadKey();

            }
            { //    <= 

                int a = 10;
                int b = 4;

                bool c = a <= b;

                bool d = a <= 25;

                Console.WriteLine($"{a} <= {b} , result {c}");
                Console.WriteLine($"{a} <= {25} , result {d}");
                Console.WriteLine("________________________________________________");
                Console.ReadKey();




            }
            { //    <= 

                int a = 10;
                int b = 4;

                bool c = a <= b;

                bool d = a <= 25;

                Console.WriteLine($"{a} <= {b} , result {c}");
                Console.WriteLine($"{a} <= {25} , result {d}");
                Console.WriteLine("________________________________________________");
                Console.ReadKey();




            }
            { //    >=

                int a = 10;
                int b = 4;

                bool c = a >= b;

                bool d = a >= 25;

                Console.WriteLine($"{a} <= {b} , result {c}");
                Console.WriteLine($"{a} <= {25} , result {d}");
                Console.WriteLine("________________________________________________");
                Console.ReadKey();



            }

            {   // логическая операция  | 
                bool x1 = (5 > 6) | (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
                bool x2 = (5 > 6) | (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
            }

            {   // логическая операция  &
                bool x1 = (5 > 6) & (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
                bool x2 = (5 < 6) & (4 < 6); // 5 < 6 - true, 4 < 6 - true, поэтому возвращается true
            }


            {   // логическая операция  ||
                bool x1 = (5 > 6) || (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
                bool x2 = (5 > 6) || (4 > 6); // 5 > 6 - false, 4 > 6 - false, поэтому возвращается false
            }

            {   // логическая операция  &&
                bool x1 = (5 > 6) && (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается false
                bool x2 = (5 < 6) && (4 < 6); // 5 < 6 - true, 4 > 6 - true, поэтому возвращается true
            }

            {   // логическая операция !
                bool a = true;
                bool b = !a;    // false
            }

            {   // логическая операция ^
                bool x5 = (5 > 6) ^ (4 < 6); // 5 > 6 - false, 4 < 6 - true, поэтому возвращается true
                bool x6 = (50 > 6) ^ (4 / 2 < 3); // 50 > 6 - true, 4/2 < 3 - true, поэтому возвращается false
            }






        }
    }
}
