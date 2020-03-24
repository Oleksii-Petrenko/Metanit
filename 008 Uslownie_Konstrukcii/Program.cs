using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Uslownie_Konstrukcii
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            int num2 = 6;

            if (num1 > num2)
            {
                Console.WriteLine($"Number {num1} bigger than {num2}");
            }
            
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }

            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали букву Y");
                    break;

                case "N":
                    Console.WriteLine("Вы нажали букву N");
                    break;

                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                   
                    break;

            }

            Console.WriteLine("Ведите читсло от 1 до 7");
            string numberSet = Console.ReadLine();

            int number = Convert.ToInt32(numberSet);
            
            switch (number)
            {
                case 1:
                    Console.WriteLine("Вы нажали цифру 1");
                    break;
                case 2:
                    Console.WriteLine("Вы нажали цифру 2");
                    break;
                case 3:
                    Console.WriteLine("Вы нажали цифру 3");
                    goto case 6;
                case 4:
                    Console.WriteLine("Вы нажали цифру 4");
                    break;
                case 5:
                    Console.WriteLine("Вы нажали цифру 5");
                    break;
                case 6:
                    Console.WriteLine("Вы нажали цифру 6");
                    break;
                case 7:
                    Console.WriteLine("Вы нажали цифру 7");
                    break;
                default:
                    Console.WriteLine("Вы нажали цифру какой нет в предложеных");
                    break;

            }


        }
    }
}
