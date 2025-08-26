namespace SingletonExample
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        public static Singleton Instance => instance;

        public string Connection { get; set; } = "124";
    }
}
