using Core.Services.PaymentServices;

namespace Application.Payment;

public class ZarinPalPayment:IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay {amount} with ZarinPal");
    }
}