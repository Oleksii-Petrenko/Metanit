using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017_Perechisleniya_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Operatin op;

            op = Operatin.Add;
            Console.WriteLine(op);
            Console.ReadLine();
            op = Operatin.Substract;


        }

        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }

        enum Time : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        enum Operatin
        {
            Add = 2,
            Substract = 4,
            Multiply = 8,
            Divide = 16,
        }

        enum Operation
        {
            Add ,
            Subtract,
            Multiply,
            Divide
        }

        static void MathOp(double x, double y, Operation op)
        {
            double result = 0.0;

            switch (op)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
            }

            Console.WriteLine("Результат операции равен {0}", result);
        }

    }
}
