using System;

namespace _004_Implementing_Interfaces_in_Base_and_Derived_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseAction hero = new HeroAction();
            hero.Move();

            BaseAction action1 = new HeroAction();
            action1.Move();            // Move in BaseAction

            IAction action2 = new HeroAction();
            action2.Move();             // Move in HeroAction

            Console.WriteLine("Hello World!");
        }
    }
    interface IAction
    {
        void Move();
    }
    class BaseAction : IAction
    {
        public virtual void Move()
        {
            Console.WriteLine("Move in BaseAction");
        }
    }
    class HeroAction : BaseAction, IAction
    {
        public new void Move()
        {
            Console.WriteLine("Move in HeroAction");
        }
    }
}
