using System;
using System.Threading;

namespace _002_Application_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Car car = new Car();
            //Action(person);
            //Action(car);
            //Console.Read();

            // Все объекты Client являются объектами IAccount 
            IAccount account = new Client("Том", 200);
            account.Put(200);
            Console.WriteLine(account.CurrentSum); // 400
                                                   // Не все объекты IAccount являются объектами Client, необходимо явное приведение
            Client client = (Client)account;
            // Интерфейс IAccount не имеет свойства Name, необходимо явное приведение
            string clientName = ((Client)account).Name;

        }

        static void Action(IMovable movable)
        {
            movable.Move();
        }

         #region Imovable
        interface IMovable
        {
            void Move();
        }
        class Person : IMovable
        {
            public void Move()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Человек идет");
                    Thread.Sleep(500);
                }
                
            }
        }
        struct Car : IMovable
        {
            public void Move()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Машина едет");
                    Thread.Sleep(500);

                }
                
            }
        }

        #endregion 
        interface IAccount
        {
            int CurrentSum { get; }  // Текущая сумма на счету
            void Put(int sum);      // Положить деньги на счет
            void Withdraw(int sum); // Взять со счета
        }
        interface IClient
        {
            string Name { get; set; }
        }
        class Client : IAccount, IClient
        {
            int _sum; // Переменная для хранения суммы
            public string Name { get; set; }
            public Client(string name, int sum)
            {
                Name = name;
                _sum = sum;
            }

            public int CurrentSum { get { return _sum; } }

            public void Put(int sum) { _sum += sum; }

            public void Withdraw(int sum)
            {
                if (_sum >= sum)
                {
                    _sum -= sum;
                }
            }
        }

    }
}
