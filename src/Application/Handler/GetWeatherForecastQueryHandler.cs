using MediatR;
using WebApplication1.Application.Query;
using WebApplication1.Domain.Entity;

namespace WebApplication1.Application.Handler
{
    public class GetWeatherForecastQueryHandler : IRequestHandler<GetWeatherForecastQuery, WeatherForecast>
    {
        public Task<WeatherForecast> Handle(
            GetWeatherForecastQuery request,
            CancellationToken cancellationToken)
        {
            var forecast = GetWeatherForecast()
                .First(wf => wf.Date == request.Date);
            return Task.FromResult(forecast);
        }

        private IList<WeatherForecast> GetWeatherForecast()
        {
            return new List<WeatherForecast>
            {
                new WeatherForecast(DateTime.UtcNow.Date),
                new WeatherForecast(DateTime.UtcNow.Date.AddDays(-1))
            };
        }
    }
}
