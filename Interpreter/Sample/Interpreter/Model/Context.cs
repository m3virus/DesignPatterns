namespace Interpreter.Model
{
    public class Context
    {
        public string Expression { get; }
        public Context(string expression) => Expression = expression;
    }

}
