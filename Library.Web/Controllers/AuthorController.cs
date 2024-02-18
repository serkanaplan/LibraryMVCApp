using Library.Core.DTOs;
using Library.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.Web.Controllers
{
    public class AuthorController : Controller
    { 
        private readonly AuthorApiService _authorApiService;

        public AuthorController(AuthorApiService authorApiService)
        {
            _authorApiService = authorApiService;
        }

		public async Task<IActionResult> Index()
		{
			var authors = await _authorApiService.GetAuthors();
			return View(authors);
		}

	}
}
