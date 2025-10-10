namespace VisitorPattern.Model
{
    internal class ShoppingCartVisitor:IVisitor
    {
        public void Visit(Book book)
        {
            Console.WriteLine($"کتاب: {book.Title}, قیمت: {book.Price} تومان");
        }

        public void Visit(Fruit fruit)
        {
            int cost = fruit.PricePerKg * fruit.Weight;
            Console.WriteLine($"میوه: {fruit.Name}, قیمت کل: {cost} تومان");
        }
    }
}
