using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class ShelfController:BaseController
    {
        private readonly IShelfService _shelfService;
        private readonly IMapper _mapper;

        public ShelfController(IShelfService shelfService, IMapper mapper)
        {
            _shelfService = shelfService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var shelves = await _shelfService.GetAllAsync();
            var shelfDtos = _mapper.Map<IEnumerable<ShelfDTO>>(shelves.ToList());
            return Ok(shelfDtos);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var shelf = await _shelfService.GetByIdAsync(id);
                if (shelf == null)
                    return NotFound();
                var shelfDtos = _mapper.Map<ShelfDTO>(shelf);
                return Ok(shelfDtos);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(ShelfDTO shelfDto)
        {
            try
            {
                var shelf = await _shelfService.AddAsync(_mapper.Map<Shelf>(shelfDto));
                var shelfDtos = _mapper.Map<ShelfDTO>(shelf);
                return Ok(shelfDtos);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(ShelfDTO shelfDto)
        {
            try
            {
                await _shelfService.UpdateAsync(_mapper.Map<Shelf>(shelfDto));
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
                var shelf = await _shelfService.GetByIdAsync(id);
                await _shelfService.RemoveAsync(shelf);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
