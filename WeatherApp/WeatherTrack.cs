using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WeatherTrack
    {
        public double Temp { get; set; }
        public double Wind { get; set; }
        public string Overcast { get; set; }
        public double Clouds { get; set;}
        public double Humidity { get; set; }
        public void WeatherTracking()
        {
            var client = new HttpClient(); //http request
            var key = File.ReadAllText("appsettings.json");

            var APIkey = JObject.Parse(key).GetValue("apikey").ToString();
            Console.WriteLine("Please Enter your Zip Code");
            var zipCode = Console.ReadLine();

            var weather = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";

            var weatherResponse = client.GetStringAsync(weather).Result;
            this.Temp = double.Parse(JObject.Parse(weatherResponse)["main"]["temp"].ToString());
            this.Humidity = double.Parse(JObject.Parse(weatherResponse)["main"]["humidity"].ToString());
            this.Wind = double.Parse(JObject.Parse(weatherResponse)["wind"]["speed"].ToString());
            this.Overcast = JObject.Parse(weatherResponse)["weather"][0]["description"].ToString();
            this.Clouds = double.Parse(JObject.Parse(weatherResponse)["clouds"]["all"].ToString());

        }
    }
}
