using FluentValidation;
using WebApplication1.Application.Query;

namespace WebApplication1.Application.Validator
{
    public class GetWeatherForecastQueryValidator : AbstractValidator<GetWeatherForecastQuery>
    {
        public GetWeatherForecastQueryValidator()
        {
            RuleFor(wf => wf.Date)
                .GreaterThan(DateTime.MinValue)
                .WithMessage("Invalid Date");

            RuleFor(wf => wf.Date)
                .LessThanOrEqualTo(DateTime.UtcNow.Date)
                .WithMessage("Date should be less then or equal today at 12pm");
        }
    }
}
