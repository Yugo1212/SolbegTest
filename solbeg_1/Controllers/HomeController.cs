using Microsoft.AspNetCore.Mvc;
using solbeg_1.Models;
using System.Diagnostics;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;

namespace solbeg_1.Controllers
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

        public IActionResult ReverseString(string text)
        {
            StringBuilder reversedText = new();
   
            for (var i = text.Length; i > 0;)
            {
                reversedText.Append(text[i - 1]);
                i--;
            }

            return Content($"{reversedText}", "application/json");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });   
        }
    }
}