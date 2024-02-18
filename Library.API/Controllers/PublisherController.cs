using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class PublisherController : BaseController
    {
        private readonly IPublisherService _publisherService;
        private readonly IMapper _mapper;

        public PublisherController(IPublisherService publisherService, IMapper mapper)
        {
            _publisherService = publisherService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var publishers = await _publisherService.GetAllAsync();
            var publisherDtos = _mapper.Map<IEnumerable<PublisherDTO>>(publishers.ToList());
            return Ok(publisherDtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var publisher = await _publisherService.GetByIdAsync(id);
                var publisherDtos = _mapper.Map<PublisherDTO>(publisher);
                return Ok(publisherDtos);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(PublisherDTO publisherDto)
        {
            try
            {
                var publisher = await _publisherService.AddAsync(_mapper.Map<Publisher>(publisherDto));
                var publisherDTO = _mapper.Map<PublisherDTO>(publisher);
                return Ok(publisherDTO);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpPut]
        public async Task<IActionResult> Update(PublisherDTO publisherDto)
        {
            try
            {
                await _publisherService.UpdateAsync(_mapper.Map<Publisher>(publisherDto));
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                var publisher =await _publisherService.GetByIdAsync(id);
                await _publisherService.RemoveAsync(publisher);
                return Ok();
            }
            catch (Exception)
            {

               return BadRequest();
            }
        }
    }
}
