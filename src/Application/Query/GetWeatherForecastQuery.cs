using MediatR;
using WebApplication1.Domain.Entity;

namespace WebApplication1.Application.Query
{
    public class GetWeatherForecastQuery : IRequest<WeatherForecast>
    {
        public DateTime Date { get; set; }
    }
}
