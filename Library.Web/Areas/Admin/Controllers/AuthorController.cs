using Library.Core.DTOs;
using Library.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class AuthorController : Controller
{
    private readonly AuthorApiService _authorApiService;
    private readonly CountryApiService _countryApiService;
    public AuthorController(AuthorApiService authorApiService, CountryApiService countryApiService)
    {
        _authorApiService = authorApiService;
        _countryApiService = countryApiService;
    }

    [HttpGet]
    public async Task<IActionResult> Read()
    {
        var model = await _authorApiService.GetAuthors();
        return View(model);
    }

    public IActionResult CreateAuthor()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([FromForm] AuthorDTO authorDto, IFormFile file)
    {
        ViewBag.Categories = new SelectList(await _countryApiService.GetCountry(), "CategoryId", "NameSurname");
        if (ModelState.IsValid)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", "Author", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            authorDto.Img = file.FileName;
            _ = _authorApiService.CreateAuthor(authorDto);
            return RedirectToAction("Dashboard");
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "id")] int id)
    {
        ViewBag.Categories = new SelectList(await _countryApiService.GetCountry(), "CategoryId", "NameSurname");
        var model = await _authorApiService.GetAuthorById(id);
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update([FromForm] AuthorDTO authorDto, IFormFile file)
    {
        ViewBag.Categories = new SelectList(await _countryApiService.GetCountry(), "CategoryId", "NameSurname");
        if (ModelState.IsValid)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", "Author", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            authorDto.Img = file.FileName;
            await _authorApiService.UpdateAuthor(authorDto);
            return RedirectToAction("Dashboard");
        }
        return View();
    }


    public IActionResult Delete([FromRoute(Name = "id")] int id)
    {
        _ = _authorApiService.DeleteAuthor(id);
        return RedirectToAction("Dashboard");
    }

}
