using FluentValidation;
using Library.Core.DTOs;

namespace Library.Service.Validations
{
    public class BookDTOForInsertionValidator:AbstractValidator<BookDTOForInsertion>
    {
        public BookDTOForInsertionValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(x => x.AuthorId).NotEmpty().WithMessage("Author cannot be empty");
            RuleFor(x => x.PublisherId).NotEmpty().WithMessage("Publisher cannot be empty");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Category cannot be empty");
            RuleFor(x => x.LanguageId).NotEmpty().WithMessage("Language cannot be empty");
            RuleFor(x => x.Img).Empty().WithMessage("Picture cannot be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description cannot be empty");
            RuleFor(x=>x.ShelfId).NotEmpty().WithMessage("Shelf cannot be empty");
            RuleFor(x=>x.PublishedDate).NotEmpty().WithMessage("PublishedDate cannot be empty");
        }

    }
}
