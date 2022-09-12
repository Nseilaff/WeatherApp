using Newtonsoft.Json.Linq;
using WeatherApp;

var weather = new WeatherTrack();
weather.WeatherTracking();
Console.WriteLine(weather.Temp);
Console.WriteLine(weather.Humidity);
Console.WriteLine(weather.Wind);
Console.WriteLine(weather.Overcast);
Console.WriteLine(weather.Clouds);



