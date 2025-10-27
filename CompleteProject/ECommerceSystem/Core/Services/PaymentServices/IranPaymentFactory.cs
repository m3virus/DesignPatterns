namespace Core.Services.PaymentServices
{
    public class IranPaymentFactory:IStoreFactory
    {
        public IPaymentService CreatePayment()
        {
            return new ZarinPalPayment();
        }

        public IShippingService CreateShipping()
        {
            return new PostShipping();
        }
    }
}
