using System;

namespace StrategyPattern.WithDesignPrinciple
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("i can't Fly.");
        }
    }

}
