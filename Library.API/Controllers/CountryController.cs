using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class CountryController:BaseController
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;
        public CountryController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var countries = await _countryService.GetAllAsync();
            var countryDtos = _mapper.Map<IEnumerable<CountryDTO>>(countries.ToList());

            return Ok(countryDtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var country = await _countryService.GetByIdAsync(id);
            var countryDtos = _mapper.Map<CountryDTO>(country);

            return Ok(countryDtos);
        }

        [HttpPost]
        public async Task<IActionResult> Save(CountryDTO countryDto)
        {
            var country = await _countryService.AddAsync(_mapper.Map<Country>(countryDto));
            var countryDtos = _mapper.Map<CountryDTO>(country);
            return Ok(countryDtos);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CountryDTO countryDto)
        {
            await _countryService.UpdateAsync(_mapper.Map<Country>(countryDto));
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Remove(int id)
        {
            var country = await _countryService.GetByIdAsync(id);
            await _countryService.RemoveAsync(country);
            return Ok();
        }
    }
}
