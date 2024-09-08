using Library_NPR321.Models;
using Library_NPR321.Models.ViewModels;
using Library_NPR321.Repositories.Authors;
using Library_NPR321.Repositories.Books;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Library_NPR321.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;

        public HomeController(ILogger<HomeController> logger, IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _logger = logger;
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeVM
            {
                Books = _bookRepository.Books,
                Authors = _authorRepository.Authors
            };

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
