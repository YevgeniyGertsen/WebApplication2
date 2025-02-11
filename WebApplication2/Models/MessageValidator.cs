using FluentValidation;

namespace WebApplication2.Models
{
    public class MessageValidator : AbstractValidator<Message>
    {
        private readonly string[] _allowedCities = new[] { "Almaty", "Astana"};

        public MessageValidator()
        {
            RuleFor(x => x.City)
                .NotEmpty()
                .Length(3)
                .Must(value => _allowedCities.Contains(value))
                .WithMessage("Not a valid city");
        }
    }
}
