using System;

namespace _003_Explicit_implementation_of_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseAction baseAction = new BaseAction();
            //((IAction)baseAction).Move();

            //Console.WriteLine("Hello World!");
            PersonOne p = new PersonOne();

            ((ISchool)p).Study();
            ((IUniversity)p).Study();

            Console.Read();
        }
    }
    #region Action move
    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        void IAction.Move()
        {
            Console.WriteLine("Move in Base Class");
        }
    }

    class Person : ISchool, IUniversity
    {
        public void Study()
        {
            Console.WriteLine("Учеба в школе или в университете");
        }
    }
    #endregion 
    interface ISchool
    {
        void Study();
    }

    interface IUniversity
    {
        void Study();
    }
    class PersonOne : ISchool, IUniversity
    {
        void ISchool.Study()
        {
            Console.WriteLine("Учеба в школе");
        }
        void IUniversity.Study()
        {
            Console.WriteLine("Учеба в университете");
        }
    }
}
