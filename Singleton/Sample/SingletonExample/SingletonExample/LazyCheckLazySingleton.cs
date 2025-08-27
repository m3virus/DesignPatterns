namespace SingletonExample
{
    public sealed class LazyCheckLazySingleton
    {
        private static Lazy<LazyCheckLazySingleton> instance = new Lazy<LazyCheckLazySingleton>();

        private LazyCheckLazySingleton()
        {
            
        }
        public static LazyCheckLazySingleton  Instance => instance.Value;
        
        public string Connection { get; set; } = "124";
    }
}
