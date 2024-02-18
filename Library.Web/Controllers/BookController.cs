using Library.Core.DTOs;
using Library.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly BookApiService _bookApiService;
        private readonly CategoryApiService _categoryApiService;

        public BookController(BookApiService bookApiService, CategoryApiService categoryApiService)
        {
            _bookApiService = bookApiService;
            _categoryApiService = categoryApiService;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _bookApiService.GetBooksWithCategoryAndAuthor());
        }


        public async Task<IActionResult> Save()
        {
            var categories = await _categoryApiService.GetCategories();

            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(BookDTOForInsertion bookDto)
        {
            if (ModelState.IsValid)
            {
                await _bookApiService.CreateBook(bookDto);
                return RedirectToAction(nameof(Index));
            }

            var categories = await _categoryApiService.GetCategories();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }


        public async Task<IActionResult> Edit(int id)
        {
            var book = await _bookApiService.GetBookById(id);
            var categories = await _categoryApiService.GetCategories();

            ViewBag.Categories = new SelectList(categories, "Id", "Name",book.CategoryId);
            return View(book);
        }


        [HttpPut]
        public async Task<IActionResult> Edit(int id,BookDTOForUpdate bookDTOForUpdate)
        {
            if (ModelState.IsValid)
            {
                await _bookApiService.UpdateBook(bookDTOForUpdate);
                return RedirectToAction(nameof(Index));
            }
            var categories = await _categoryApiService.GetCategories();
            ViewBag.Categories = new SelectList(categories, "Id", "Name", bookDTOForUpdate.CategoryId);
            return View(bookDTOForUpdate);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _bookApiService.DeleteBook(id);
            return RedirectToAction(nameof(Index));
        }

    }   
}
