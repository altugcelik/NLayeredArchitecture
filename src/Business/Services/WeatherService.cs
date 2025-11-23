using Business.DTOs;
using Business.Interfaces;
using DataAccess.Interfaces;

namespace Business.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _repo;

        public WeatherService(IWeatherRepository repo)
        {
            _repo = repo;
        }

        public WeatherDto GetForecast(WeatherRequestDto request)
        {
            var entity = _repo.FetchForecast(request.City);

            return new WeatherDto
            {
                City = entity.City,
                Temperature = entity.Temperature,
                Condition = entity.Condition
            };
        }
    }
}
