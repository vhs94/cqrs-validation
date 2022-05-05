using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Application.Query;
using WebApplication1.Domain.Entity;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<WeatherForecast> Get(DateTime date)
        {
            return await _mediator.Send(new GetWeatherForecastQuery
            {
                Date = date
            });
        }
    }
}