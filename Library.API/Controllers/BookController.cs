using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class BookController : BaseController    
    {
        private readonly IMapper _mapper;
        private readonly IBookService _bookService;

        public BookController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var books = await _bookService.GetBooksWithAuthorAndCategory();
            var bookDtos = _mapper.Map<IEnumerable<BooksWithAuthorAndCategoryDTO>>(books.ToList());

           return Ok(bookDtos);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {

            try
            {
                var book = await _bookService.GetByIdAsync(id);
                if (book == null)
                {
                    return NotFound();
                }
                var bookDtos = _mapper.Map<BookDTO>(book);
                return Ok(bookDtos);
            }
            catch (Exception)
            {

                return NotFound();
            }
         
        }

        [HttpPost]
        public async Task<IActionResult> Save(BookDTO bookDto)
        {
            var book = await _bookService.AddAsync(_mapper.Map<Book>(bookDto));
            var bookDTO = _mapper.Map<BookDTO>(book);

            return Ok(bookDTO);
        }

        [HttpPut]
        public async Task<IActionResult> Update(BookDTOForUpdate bookDtoforupdate)
        {
                await _bookService.UpdateAsync(_mapper.Map<Book>(bookDtoforupdate));

                return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                var book = await _bookService.GetByIdAsync(id);
                await _bookService.RemoveAsync(book);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
