using Core.Services.PaymentServices;

namespace Application.Payment;

public class PostShipping:IShippingService
{
    public void Ship(string Product)
    {
        Console.WriteLine($"Your {Product} send by FedEx");
    }
}