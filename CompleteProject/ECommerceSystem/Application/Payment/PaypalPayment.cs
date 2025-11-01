using Core.Services.PaymentServices;

namespace Application.Payment;

public class PaypalPayment: IPaymentService
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Pay {amount} with PayPal");
    }
}