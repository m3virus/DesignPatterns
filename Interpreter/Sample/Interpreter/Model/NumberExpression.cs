namespace Interpreter.Model
{
    internal class NumberExpression : IExpression
    {
        private int number;
        public NumberExpression(int number) => this.number = number;
        
        public int Interpret() => number;
    }
}
