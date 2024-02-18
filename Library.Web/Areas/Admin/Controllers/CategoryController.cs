using Library.Core.DTOs;
using Library.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _categoryApiService;
        public CategoryController(CategoryApiService categoryApiService)
        {
            this._categoryApiService = categoryApiService;
        }

        public async Task<IActionResult> Read()
        {
            var model = await _categoryApiService.GetCategories();
            return View(model);
        }

    }
}
