using VisitorPattern.Model;

List<IItemElement> items = new List<IItemElement>
{
    new Book("Design Patterns", 200000),
    new Fruit("سیب", 50000, 2)
};

IVisitor visitor = new ShoppingCartVisitor();

foreach (var item in items)
{
    item.Accept(visitor);
}