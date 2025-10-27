using System.Security.Cryptography.X509Certificates;
using Core.Models.Product;

// Prototype pattern
namespace Core.Services.ProductServices
{
    public class ProductTemplate:ProductBase
    {
        public string Category { get; set; }
        public override ProductPrototype Clone()
        {
            return (ProductPrototype)this.MemberwiseClone();
        }

        public override void Detail()
        {
            throw new NotImplementedException();
        }
    }
}

