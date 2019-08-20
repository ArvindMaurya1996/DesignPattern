using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.WithDesignPrinciple
{

    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Can't Quack. I am muted Duck");
        }
    }
}
