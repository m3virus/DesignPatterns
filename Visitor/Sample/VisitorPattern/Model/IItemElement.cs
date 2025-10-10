namespace VisitorPattern.Model
{
    internal interface IItemElement
    {
        void Accept(IVisitor visitor);
    }
}
