using GMToolset.Presentation.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using System.Diagnostics;

namespace GMToolset.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHtmlLocalizer<HomeController> _htmlLocalizer;

        public HomeController(ILogger<HomeController> logger, IHtmlLocalizer<HomeController> htmlLocalizer)
        {
            _logger = logger;
            _htmlLocalizer = htmlLocalizer;
        }

        public IActionResult Index()
        {
            var test = _htmlLocalizer["Test"];
            return View(test);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LanguageToggle(string cultureName)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cultureName)), new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddDays(30)
            });
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}