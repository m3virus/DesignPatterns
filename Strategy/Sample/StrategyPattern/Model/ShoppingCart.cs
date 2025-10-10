namespace StrategyPattern.Model
{
    internal class ShoppingCart
    {
        private IPaymentStrategy _payment;

        public void SetStrategy(IPaymentStrategy payment)
        {
            _payment = payment;
        }

        public void CheckOut(decimal amount)
        {
            if (_payment is null)
            {
                Console.WriteLine("Please select payment");
                return;
            }
            _payment.Pay(amount);
        }
    }
}
