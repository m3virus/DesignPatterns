using Core.Services.PaymentServices;

namespace Application.Payment;

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