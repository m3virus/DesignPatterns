using Interpreter.Model;

IExpression expr = new AddExpression(
    new NumberExpression(5),
    new SubtractExpression(new NumberExpression(10), new NumberExpression(3))
);

Console.WriteLine(expr.Interpret()); 