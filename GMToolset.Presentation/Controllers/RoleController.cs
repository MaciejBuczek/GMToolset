using GMToolset.Presentation.Helpers.Intefaces;
using GMToolset.Presentation.ViewModels.Role;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GMToolset.Presentation.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleControllerManager _roleManager;

        public RoleController(IRoleControllerManager roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            ViewData["UsernameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "username_desc" : "";
            ViewData["EmailSortParm"] = sortOrder == "email" ? "email_desc" : "email";
            ViewData["AdminSortParm"] = sortOrder == "admin" ? "admin_desc" : "admin";
            ViewData["CurrentSort"] = sortOrder;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            return View(await _roleManager.CreateUserRoleViewModel(sortOrder, currentFilter, searchString, pageNumber));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Required] string name)
        {
            if (ModelState.IsValid)
            {
                if (await _roleManager.CreateRole(name))
                    return RedirectToAction("Index");
            }
            return View(name);
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            return View(await _roleManager.GetRoleAndUsers(id));
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel vm)
        {

            if (await _roleManager.UpdateRole(vm))
                return RedirectToAction("Index");

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRole(string id)
        {
            await _roleManager.DeleteRole(id);

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUsersRoles(UserRoleViewModel vm)
        {
            await _roleManager.UpdateUsersRoles(vm);

            return RedirectToAction("Index");
        }
    }

}
