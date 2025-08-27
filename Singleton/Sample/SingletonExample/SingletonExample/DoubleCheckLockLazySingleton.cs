namespace SingletonExample
{
    public sealed class DoubleCheckLockLazySingleton
    {
        private static DoubleCheckLockLazySingleton instance;
        private static readonly object locker = new object();

        private DoubleCheckLockLazySingleton()
        {
            
        }
        public static DoubleCheckLockLazySingleton Instance
        {
            get
            {

                if (instance == null)
                {
                    lock (locker)
                    {
                        instance = new DoubleCheckLockLazySingleton();

                    }
                }
                return instance;
            }
        }
        public string Connection { get; set; } = "124";
    }
}
