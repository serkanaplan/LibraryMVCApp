using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Services;
using Library.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ServiceBase.Services
{
    public class BookService : ServiceBase<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;
        public BookService(IRepositoryBase<Book> repository, IUnitOfWork unitofwork, IMapper mapper, IBookRepository bookRepository) : base(repository, unitofwork)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public async Task<List<BooksWithAuthorAndCategoryDTO>> GetBooksWithAuthorAndCategory()
        {
            var books =await _bookRepository.GetBooksWithAuthorAndCategory();
            return _mapper.Map<List<BooksWithAuthorAndCategoryDTO>>(books);
        }

        public async Task<List<BookWithAuthorDTO>> GetBookWithAuthor()
        {
            var books =await _bookRepository.GetBooksWithAuthor();
            return _mapper.Map<List<BookWithAuthorDTO>>(books);
        }

        public async Task<List<BookWithCategoryDTO>> GetBookWithCategory()
        {
            var books =await _bookRepository.GetBooksWithCategory();

            return _mapper.Map<List<BookWithCategoryDTO>>(books);

        }


    }
}
