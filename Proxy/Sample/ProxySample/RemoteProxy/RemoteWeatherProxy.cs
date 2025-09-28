namespace ProxySample.RemoteProxy
{
    internal class RemoteWeatherProxy : IWeatherServices
    {
        private RealWeatherServices _services = new();
        public string GetWeather()
        {
            Console.WriteLine("proxy called");
            return _services.GetWeather();
        }
    }
}
