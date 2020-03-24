using System;

namespace _025_Try_Catch_Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

            finally
            {
                
                Console.WriteLine("Конец программы");
                Console.Read();
            }
            
            
        }
    }
}
