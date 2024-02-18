

using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class LanguageDTOValidator : AbstractValidator<LanguageDTO>
    {
        public LanguageDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
