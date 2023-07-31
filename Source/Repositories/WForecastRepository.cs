using WeatherApp.OpenWeatherMap_Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Configuration;
using WeatherApp.OpenWeatherMap_Models;
using WeatherApp.Repositories;

namespace WeatherApp.Repositories
{
    public class WForecastRepository : IWForecastRepository
    {
        public WeatherResponse GetForecast(string city)
        {
            string APP_ID = Configuration.Values.OPEN_WEATHER_APP_ID;
            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={APP_ID}");
            RestRequest request = new(Method.GET);
            var response = client.Execute(request);

            if (response.IsSuccessful && response != null)
            {
                // Deserialize the string content into JToken object
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content?.ToObject<WeatherResponse>();
            }

            // Deserialize the JToken object into our WeatherResponse Class
            return null;
        }
    }
}
