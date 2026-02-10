using HybridTest.Shared.Models;

namespace HybridTest.Shared.Services;

public interface IWeatherService
{
    Task<WeatherForecast[]> GetForecastAsync();
}
