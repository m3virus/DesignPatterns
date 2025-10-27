namespace Core.Services.PaymentServices;

internal class AmericanPaymentFactory:IStoreFactory
{
    public IPaymentService CreatePayment()
    {
        return new PaypalPayment();
    }

    public IShippingService CreateShipping()
    {
        return new FedExShipping();
    }
}