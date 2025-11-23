using Core.Entities;
using DataAccess.Interfaces;

namespace DataAccess.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        public WeatherForecast FetchForecast(string city)
        {
            return new WeatherForecast
            {
                City = city,
                Temperature = 22,
                Condition = "Sunny"
            };
        }
    }
}
