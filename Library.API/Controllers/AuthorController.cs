using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class AuthorController : BaseController  
    {
        private readonly IMapper _mapper;
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var author = await _authorService.GetAllAsync();
            var authorDtos = _mapper.Map<IEnumerable<AuthorDTO>>(author.ToList());
            return Ok(authorDtos);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {

            try
            {
                var author = await _authorService.GetByIdAsync(id);
                if (author == null)
                {
                    return NotFound();
                }
                var authorDto = _mapper.Map<AuthorDTO>(author);
                return Ok(authorDto);
            }
            catch (Exception)
            {

                return NotFound();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Save(AuthorDTO authorDto)
        {
            var author = await _authorService.AddAsync(_mapper.Map<Author>(authorDto));
            var authorDTO = _mapper.Map<AuthorDTO>(author);

            return Ok(authorDTO);
        }

        [HttpPut]
        public async Task<IActionResult> Update(AuthorDTO authordto)
        {
            try
            {
                await _authorService.UpdateAsync(_mapper.Map<Author>(authordto));

                return NoContent();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                var author = await _authorService.GetByIdAsync(id);
                await _authorService.RemoveAsync(author);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
