using Core.Entities;

namespace DataAccess.Interfaces
{
    public interface IWeatherRepository
    {
        WeatherForecast FetchForecast(string city);
    }
}
