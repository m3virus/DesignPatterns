namespace StrategyPattern.Model
{
    internal interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
