namespace VisitorPattern.Model
{
    internal interface IVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
    }
}
