
using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class CountryDTOValidator : AbstractValidator<CountryDTO>
    {
        public CountryDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Img).NotEmpty().WithMessage("Picture cannot be empty");
        }
    }
}
