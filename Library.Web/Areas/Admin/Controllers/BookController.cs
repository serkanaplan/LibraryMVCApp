using Library.Core.DTOs;
using Library.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StoreApp.Areas.Admin.Controllers;

[Area("Admin")]
public class BookController : Controller
{
    private readonly BookApiService _bookApiService;
    private readonly CategoryApiService  _categoryApiService;
    private readonly AuthorApiService _authorApiService;
    private readonly PublisherApiService _publisherApiService;
    private readonly LanguageApiService _languageApiService;
    private readonly ShelfApiService _shelfApiService;

    public BookController(BookApiService bookApiService, AuthorApiService authorApiService, CategoryApiService categoryApiService, PublisherApiService publisherApiService, LanguageApiService languageApiService, ShelfApiService shelfApiService)
    {
        _bookApiService = bookApiService;
        _authorApiService = authorApiService;
        _categoryApiService = categoryApiService;
        _publisherApiService = publisherApiService;
        _languageApiService = languageApiService;
        _shelfApiService = shelfApiService;
    }

    public async Task<IActionResult> Read()    
    {
        var model =await _bookApiService.GetBooks();
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        await Selectedlists();
        return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([FromForm] BookDTOForInsertion bookDTOForInsertion, IFormFile file)//formdan işlenen bir product parametre olarak bu methoda gelecek [FromForm] zorunlu değil sadece verinin nereden geldiğini sembolize etmek için var
    {
        await Selectedlists();
        if (ModelState.IsValid)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", "Book", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            bookDTOForInsertion.Img = file.FileName;
            _ = _bookApiService.CreateBook(bookDTOForInsertion);
            return RedirectToAction("Read");
        }
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Update([FromRoute(Name = "id")] int id)
    {
        await Selectedlists();
        var model =await _bookApiService.GetBookById(id);
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update([FromForm] BookDTOForUpdate bookDtoforupdate, IFormFile file)
    {
        await Selectedlists();
        if (ModelState.IsValid)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", "Book", file.FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            bookDtoforupdate.Img = file.FileName;
            await _bookApiService.UpdateBook(bookDtoforupdate);
            return RedirectToAction("Read");
        }
        return View();
    }


    public IActionResult Delete([FromRoute(Name = "id")] int id)
    {
        _ = _bookApiService.DeleteBook(id);
        return RedirectToAction("Read");
    }

    public async Task Selectedlists()
    {
        ViewBag.Categories = new SelectList(await _categoryApiService.GetCategories(), "CategoryId", "Name");
        ViewBag.Authors = new SelectList(await _authorApiService.GetAuthors(), "AuthorId", "NameSurname");
        ViewBag.Publishers = new SelectList(await _publisherApiService.GetPublishers(), "PublisherId", "Name");
        ViewBag.Languages = new SelectList(await _languageApiService.GetLanguages(), "LanguageId", "Name");
        ViewBag.Shelves = new SelectList(await _shelfApiService.GetShelves(), "ShelfId", "Name");
    }
}