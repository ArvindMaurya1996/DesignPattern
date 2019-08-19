using System;

namespace StrategyPattern.WithInheritance
{
    class Duck
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack!");
        }
        public void Swim()
        {
            Console.WriteLine("I Swim!");
        }

        public void  Display()
        {
            Console.WriteLine("I am Duck.");
        }

        public virtual void Fly()
        {
            Console.WriteLine("Duck are superman!");
        }
    }
}
