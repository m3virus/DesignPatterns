namespace SingletonExample
{
    public sealed class CheckLockLazySingleton
    {
        private static CheckLockLazySingleton instance;
        private static readonly object locker = new object();

        private CheckLockLazySingleton()
        {

        }
        public static CheckLockLazySingleton Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new CheckLockLazySingleton();

                    return instance;
                }
                
            }
        }
        public string Connection { get; set; } = "124";
    }
}
