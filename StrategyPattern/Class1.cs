using StrategyPattern.WithDesignPrinciple;
using System;

namespace StrategyPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Duck App");
            Console.WriteLine("-------------------");
            Console.WriteLine("Mallard Duck.");
            Duck mallard = new MallardDuck();
            //this call the mallardDuck's inherited fly and quack method which the delegates the object's Behvior.
            mallard.Fly();
            mallard.Quack();
            Console.WriteLine("-------------------");
    

            Console.WriteLine("Mallard Duck with setting dynamic behaviour");
            //setting the behavior dynamically
            Duck dynamicMallard = new MallardDuck();
            dynamicMallard.SetFly(new FlyWithWings());
            dynamicMallard.Fly();
            dynamicMallard.SetQuack(new Quack());
            dynamicMallard.Quack();                
            Console.ReadKey();
        }
    }
}
