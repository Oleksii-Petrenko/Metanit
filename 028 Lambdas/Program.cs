using System;

namespace _028_Lambdas
{
    class Program
    {
        //delegate void Hello();
        //delegate int Operation(int x, int y);
        //delegate int Square(int x);
        //delegate void ChangeHandler(ref int x);
        delegate bool IsEqual(int x);


        static void Main(string[] args)
        {
         #region
            //Operation op = (x, y) => x + y;

            //Console.WriteLine(op(10,40));
            //Console.WriteLine(op(20,100));
            //Console.WriteLine("____________________________________________");

            //Square sq = i => i * i;

            //int z = 10;

            //Console.WriteLine(sq(z));

            //Hello h1 = () => Console.WriteLine($"hello method without params ");




            //int x = 50;
            //Console.WriteLine(x);
            //ChangeHandler change = (ref int n) => n = n * 20;
            //change(ref x);
            //Console.WriteLine(x);


            //Hello h2 = () => Show_Message();
            //h2();
            #endregion
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // найдем сумму чисел больше 5
            int result2 = Summ(integers, x => x > 5);
            Console.WriteLine(result2);

            // найдем сумму четных чисел
            int result3 = Summ(integers, x => x % 2 == 0);
            Console.WriteLine(result3); 


        }
        #region
        //private static void Show_Message()
        //{
        //    Console.WriteLine($"Message from Show_Message________________");
        //    Console.WriteLine($"___________________________________________________________________");
        //}
        #endregion
        private static int Summ(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }


    }
}
