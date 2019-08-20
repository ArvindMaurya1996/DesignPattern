using System;

namespace StrategyPattern.WithDesignPrinciple
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Can't Quack. I can squeak.");
        }
    }

}
