using Api.Models.Requests;
using Api.Models.Responses;
using Business.DTOs;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _service;

        public WeatherController(IWeatherService service)
        {
            _service = service;
        }

        [HttpPost("forecast")]
        public IActionResult GetForecast([FromBody] GetForecastRequest request)
        {
            // Map API Request → Business DTO
            var dto = new WeatherRequestDto
            {
                City = request.City
            };

            var result = _service.GetForecast(dto);

            // Map Business DTO → API Response
            var response = new WeatherResponse
            {
                City = result.City,
                Temperature = result.Temperature,
                Condition = result.Condition
            };

            return Ok(response);
        }
    }
}
