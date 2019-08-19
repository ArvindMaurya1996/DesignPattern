using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.With_Interface
{

    class DecoyDuck:Duck
    {
        //
        public void Swim()
        {
            Console.WriteLine("I Swim!");
        }
    }


}
