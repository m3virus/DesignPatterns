namespace ProxySample.RemoteProxy
{
    public class RealWeatherServices : IWeatherServices
    {
        public string GetWeather()
        {
            return "25 sunny";
        }
    }
}
