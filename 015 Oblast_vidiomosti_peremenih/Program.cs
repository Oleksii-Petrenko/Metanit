using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Oblast_vidiomosti_peremenih
{
    class Program // начало контекста класса
    {
        static int a = 9; // переменная уровня класса

        static void Main(string[] args) // начало контекста метода Main
        {
            int b = a - 1; // переменная уровня метода

            { // начало контекста блока кода

                int c = b - 1; // переменная уровня блока кода
                b = 100;
            }  // конец контекста блока кода, переменная с уничтожается

            //так нельзя, переменная c определена в блоке кода
            //Console.WriteLine(c);

            //так нельзя, переменная d определена в другом методе
            //Console.WriteLine(d);
            Console.WriteLine(b);
            Console.Read();

        } // конец контекста метода Main, переменная b уничтожается

        void Display() // начало контекста метода Display
        {
            // переменная a определена в контексте класса, поэтому доступна
            int d = a + 1;

        } // конец конекста метода Display, переменная d уничтожается

    } // конец контекста класса, переменная a уничтожается



}
