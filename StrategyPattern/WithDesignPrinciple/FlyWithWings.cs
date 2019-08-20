using System;

namespace StrategyPattern.WithDesignPrinciple
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying Duck");
        }
    }

}
