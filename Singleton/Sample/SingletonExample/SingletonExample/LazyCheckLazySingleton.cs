namespace SingletonExample
{
    public class LazyCheckLazySingleton
    {
        private static Lazy<LazyCheckLazySingleton> instance = new Lazy<LazyCheckLazySingleton>();
        public static LazyCheckLazySingleton  Instance => instance.Value;
        
        public string Connection { get; set; } = "124";
    }
}
