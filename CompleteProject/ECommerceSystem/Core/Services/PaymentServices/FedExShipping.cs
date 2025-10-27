namespace Core.Services.PaymentServices;

public class FedExShipping:IShippingService
{
    public void Ship(string Product)
    {
        Console.WriteLine($"Your {Product} send by FedEx");
    }
}