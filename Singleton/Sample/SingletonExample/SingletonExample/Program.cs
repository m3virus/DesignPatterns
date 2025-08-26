using SingletonExample;

var a = Singleton.Instance;
var b = Singleton.Instance;

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"a: {a.Connection}" +
                  $"b: {b.Connection}");
b.Connection = "444";
Console.WriteLine($"a: {a.Connection}" +
                  $"b: {b.Connection}");