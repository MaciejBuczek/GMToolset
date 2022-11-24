using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.QuickBattleManager;
using GMToolset.Services.Services.Model_Services.QuickBattleManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GMToolset.Presentation.Controllers
{
    //[Authorize]
    public class QuickSessionController : Controller
    {
        private readonly ILogger<QuickSessionController> _logger;
        private readonly IModelService<QuickSession> _quickSessionService;

        public QuickSessionController(ILogger<QuickSessionController> logger, IModelService<QuickSession> quickSessionService)
        {
            _logger = logger;
            _quickSessionService = quickSessionService;
        }
        // GET: QuickSessionController
        public ActionResult Index()
        {
            return View();
            //return View(_quickSessionService.GetAll());
        }

        // GET: QuickSessionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuickSessionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuickSessionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuickSessionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuickSessionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: QuickSessionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuickSessionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
