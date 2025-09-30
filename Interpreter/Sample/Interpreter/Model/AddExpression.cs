namespace Interpreter.Model
{
    internal class AddExpression :IExpression
    {
        private IExpression left, right;
        public AddExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public int Interpret() => left.Interpret() + right.Interpret();
    }
}
