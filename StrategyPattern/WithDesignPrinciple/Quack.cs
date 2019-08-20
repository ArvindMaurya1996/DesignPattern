using System;

namespace StrategyPattern.WithDesignPrinciple
{
    class Quack : IQuackBehavior
    {

        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack Quack!");
        }
    }

}
