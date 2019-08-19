using System;

namespace StrategyPattern.With_Interface
{
    class ReadHeadDuck : Duck, IQuackable,ISwim
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack!");
        }
        public void Swim()
        {
            Console.WriteLine("I Swim!");
        }
    }


}
