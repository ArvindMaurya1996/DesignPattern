using System;

namespace StrategyPattern.With_Interface
{
    class MallardDuck : Duck, IFlyable,ISwim
    {
        public void Fly()
        {
            Console.WriteLine("I can Fly!!");
        }
        public void Swim()
        {
            Console.WriteLine("I Swim!");
        }
    }


}
