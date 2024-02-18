
using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class UserDTOValidator:AbstractValidator<UserDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname cannot be empty");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(x => x.Img).NotEmpty().WithMessage("Picture cannot be empty");
            RuleFor(x=>x.Tin).NotEmpty().WithMessage("TIN cannot be empty");
            RuleFor(x=>x.Age).NotEmpty().WithMessage("Age cannot be empty");
            RuleFor(x => x.Gender).NotEmpty().WithMessage("Gender cannot be empty");
        }
    }
}
