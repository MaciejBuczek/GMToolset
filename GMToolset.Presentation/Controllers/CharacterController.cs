using Microsoft.AspNetCore.Mvc;

namespace GMToolset.Presentation.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult CharacterSheet()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
