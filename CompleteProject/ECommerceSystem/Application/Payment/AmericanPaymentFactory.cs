using Core.Services.PaymentServices;

namespace Application.Payment;

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