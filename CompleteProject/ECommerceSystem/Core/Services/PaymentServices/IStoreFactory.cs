namespace Core.Services.PaymentServices
{
    public interface IStoreFactory
    {
        public IPaymentService CreatePayment();
        public IShippingService CreateShipping();
    }
}
