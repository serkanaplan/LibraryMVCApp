using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    public class LanguageController : BaseController
    {
        private readonly ILanguageService _languageService;
        private readonly IMapper _mapper;

        public LanguageController(ILanguageService languageService, IMapper mapper)
        {
            _languageService = languageService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var languages = await _languageService.GetAllAsync();
            var languageDtos = _mapper.Map<IEnumerable<LanguageDTO>>(languages.ToList());
            return Ok(languageDtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var language = await _languageService.GetByIdAsync(id);
            var languageDtos = _mapper.Map<LanguageDTO>(language);
            return Ok(languageDtos);
        }

        [HttpPost]
        public async Task<IActionResult> Save(LanguageDTO languageDto)
        {
            var language = await _languageService.AddAsync(_mapper.Map<Language>(languageDto));
            var languageDtos = _mapper.Map<LanguageDTO>(language);
            return Ok(languageDtos);
        }

        [HttpPut]
        public async Task<IActionResult> Update(LanguageDTO languageDto)
        {
            await _languageService.UpdateAsync(_mapper.Map<Language>(languageDto));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var language = await _languageService.GetByIdAsync(id);
            await _languageService.RemoveAsync(language);
            return Ok();
        }
    }
}
