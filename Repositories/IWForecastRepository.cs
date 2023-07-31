using WeatherApp.OpenWeatherMap_Models;

namespace WeatherApp.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(string city);
    }
}
