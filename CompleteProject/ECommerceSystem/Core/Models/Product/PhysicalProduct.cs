namespace Core.Models.Product;

public class PhysicalProduct: ProductBase
{
    public override void Detail()
    {
        Console.WriteLine($"You built {base.Name} as physical product");
    }
}