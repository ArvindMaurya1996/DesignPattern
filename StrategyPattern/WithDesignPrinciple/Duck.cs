namespace StrategyPattern.WithDesignPrinciple
{
    abstract class Duck
    {
        //each duck has a refrence to something that implements behavior
        protected IQuackBehavior QuackBehavior;
        protected IFlyBehavior FlyBehavior;

        /// <summary>
        ///  and method to perform the behavior. we just know how to quack and fly.
        ///  we don't know what type it is weather fly with wings or fly no way.
        /// </summary>

        public void Quack() => QuackBehavior.Quack();
        public void Fly() => FlyBehavior.Fly();

        public void SetQuack(IQuackBehavior quackBehavior) => QuackBehavior = quackBehavior;
        public void SetFly(IFlyBehavior flyBehavior) => FlyBehavior = flyBehavior;
    }


}
