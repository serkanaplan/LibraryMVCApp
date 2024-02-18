
using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class ShelfDTOValidator : AbstractValidator<ShelfDTO>
    {
        public ShelfDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
