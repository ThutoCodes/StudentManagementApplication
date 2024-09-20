using Microsoft.AspNetCore.Mvc;
using SpendSmartPractice.Models;
using System.Diagnostics;

namespace SpendSmartPractice.Controllers
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
        public IActionResult Students()
        {

            return View();
        }
        public IActionResult FormSubmission(Student model)
        {

            return RedirectToAction("Students");
        }

        public IActionResult CreateEditStudentInfo()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
