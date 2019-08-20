using System;

namespace StrategyPattern.WithDesignPrinciple
{
    class MallardDuck :Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }
        
        public void Display()
        {
            Console.WriteLine("I am real mallard duck");
        }
    }

}
