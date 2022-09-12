using Newtonsoft.Json.Linq;

var client = new HttpClient(); //http request
Console.WriteLine("Please Enter your Zip Code");
var zipCode = Console.ReadLine();
var APIkey = ;
var weather = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&appid={APIkey}";

var weatherResponse = client.GetAsync(weather).Result;

var getWeather = JArray.Parse(weatherResponse.Content.ReadAsStringAsync().Result);

