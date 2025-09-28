using ProxySample.RemoteProxy;
using ProxySample.VirualProxy;

IImage img = new ImageProxy("test.png");

img.Display();
img.Display();

IWeatherServices wea = new RemoteWeatherProxy();

var a = wea.GetWeather();
Console.WriteLine(a);