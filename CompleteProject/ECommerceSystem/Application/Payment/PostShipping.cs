using Core.Services.PaymentServices;

namespace Application.Payment;

public class PostShipping:IShippingService
{
    public void Ship(string product)
    {
        Console.WriteLine($"Your {product} send by FedEx");
    }
}