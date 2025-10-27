using Core.Services.PaymentServices;

namespace Application.Payment;

public class PaypalPayment: IPaymentService
{
    public void Pay(decimal Amount)
    {
        Console.WriteLine($"Pay {Amount} with PayPal");
    }
}