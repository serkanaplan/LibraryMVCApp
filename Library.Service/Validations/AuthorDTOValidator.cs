using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class AuthorDTOValidator:AbstractValidator<AuthorDTO>
    {
        public AuthorDTOValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Biography).NotEmpty().WithMessage("Biography cannot be empty");
            RuleFor(x => x.Img).NotEmpty().WithMessage("Picture cannot be empty");
            RuleFor(x=>x.CountryId).NotEmpty().WithMessage("Country cannot be empty");
        }
    }
}
