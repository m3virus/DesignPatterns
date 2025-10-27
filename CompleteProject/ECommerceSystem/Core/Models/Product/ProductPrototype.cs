namespace Core.Models.Product;
//Prototype pattern
public abstract class ProductPrototype
{
    public string Name { get; set; }
    public abstract ProductPrototype Clone();
}