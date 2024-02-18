using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class CategoryDTOValidator : AbstractValidator<CategoryDTO>
    {
        public CategoryDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Img).NotEmpty().WithMessage("Picture cannot be empty");
        }
    }
}
