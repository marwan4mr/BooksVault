using BooksApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BooksApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult test2()
        {
            ViewData["Message"] = "Hello from test method";
            ViewBag.MessageViewBag = "Hello from ViewBag";
            TempData["MessageTempData"] = "Hello from TempData";
            return RedirectToAction(nameof(Index));
        }
        public IActionResult test()
        {
            var books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "Professional C# 7",
                    PublishDate = DateTime.Now
                },
                new Book
                {
                    Id = 2,
                    Title = "Professional C# 8",
                    PublishDate = DateTime.Now
                },
                new Book
                {
                    Id = 3,
                    Title = "Professional C# 9",
                    PublishDate = DateTime.Now
                }
            };
            return View(books);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
