namespace Interpreter.Model
{
    internal class SubtractExpression:IExpression
    {
        private IExpression left, right;
        public SubtractExpression(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }
        public int Interpret() => left.Interpret() - right.Interpret();
    }
}
