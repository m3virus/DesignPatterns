namespace Core.Services.PaymentServices
{
    public class ZarinPalPayment:IPaymentService
    {
        public void Pay(decimal Amount)
        {
            Console.WriteLine($"Pay {Amount} with ZarinPal");
        }
    }
}
