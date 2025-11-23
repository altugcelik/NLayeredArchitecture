using Business.DTOs;

namespace Business.Interfaces
{
    public interface IWeatherService
    {
        WeatherDto GetForecast(WeatherRequestDto request);
    }
}