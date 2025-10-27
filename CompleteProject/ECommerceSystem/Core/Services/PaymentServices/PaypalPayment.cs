namespace Core.Services.PaymentServices;

public class PaypalPayment: IPaymentService
{
    public void Pay(decimal Amount)
    {
        Console.WriteLine($"Pay {Amount} with PayPal");
    }
}