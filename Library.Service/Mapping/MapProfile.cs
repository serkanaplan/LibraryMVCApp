using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;

namespace Library.ServiceBase.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<BookDTOForUpdate, Book>();
            CreateMap<Author, AuthorDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Language, LanguageDTO>().ReverseMap();
            CreateMap<Transaction, TransactionDTO>().ReverseMap();
            CreateMap<Publisher, PublisherDTO>().ReverseMap();
            CreateMap<Shelf, ShelfDTO>().ReverseMap();
            CreateMap<Book, BookWithCategoryDTO>();
            CreateMap<Book, BookWithAuthorDTO>();
            CreateMap<Book, BooksWithAuthorAndCategoryDTO>();
            CreateMap<Book, BookDTOForInsertion>().ReverseMap();
            CreateMap<Book, BookDTOForUpdate>().ReverseMap();


                }
    }
}
