using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository _repo;

        public HomeController(IBookstoreRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
           var bookData = _repo.Books;

            return View(bookData);
        }
    }
}
