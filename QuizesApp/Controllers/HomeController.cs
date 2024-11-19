using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QuizesApp.Data;
using QuizesApp.Models;
using QuizesApp.ViewModels;

namespace QuizesApp.Controllers
{
    public class HomeController : Controller
    {
        private IFakeDB _fakeDB;

        public HomeController(IFakeDB fakeDB)
        {
            _fakeDB = fakeDB;
        }

        public IActionResult Index()
        {
            var model = new FakeDataViewModel(_fakeDB);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
