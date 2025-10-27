using Core.Services.PaymentServices;

namespace Application.Payment;

public class ZarinPalPayment:IPaymentService
{
    public void Pay(decimal Amount)
    {
        Console.WriteLine($"Pay {Amount} with ZarinPal");
    }
}