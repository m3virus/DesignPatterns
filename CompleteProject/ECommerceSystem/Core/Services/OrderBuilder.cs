using Core.Models;
using Core.Models.Product;
//Builder pattern
namespace Core.Services
{
    public class OrderBuilder
    {
        private readonly Order _order = new();

        public OrderBuilder SetCustomer(string name)
        {
            _order.CustormerName = name;
            return this;
        }

        public OrderBuilder SetProduct(ProductBase product, decimal price)
        {
            _order.Product.Add(product);
            _order.TotalPrice += price;
            return this;
        }
    }
}
