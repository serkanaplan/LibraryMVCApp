using Library.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _categoryApiService;

        public CategoryController(CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _categoryApiService.GetCategories());
        }


    }
}
