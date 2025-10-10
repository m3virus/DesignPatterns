using StrategyPattern.Model;

namespace StrategyPattern.DifferentStrategy
{
    internal class BitcoinPayment:IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Bitcoin : {amount}");
        }
    }
}
