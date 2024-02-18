
using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class PublisherDTOValidator : AbstractValidator<PublisherDTO>
    {
        public PublisherDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
