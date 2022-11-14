using GMToolset.Presentation.Helpers;
using GMToolset.Presentation.ViewModels;
using GMToolset.Presentation.ViewModels.Role;
using GMToolset.Presentation.ViewModels.Role.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace GMToolset.Presentation.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        #region conts
        const string roleAdmin = "Admin";
        #endregion

        public async Task<IActionResult> Index(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var vm = new UserRoleViewModel();
            var counter = 1;

            foreach (var role in _roleManager.Roles)
            {
                vm.Roles.Add(new SimpleRole()
                {
                    Id = role.Id,
                    RoleName = role.Name
                });
            }

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

            var users = new List<SimpleUser>();

            foreach (var user in _userManager.Users.ToList())
            {
                users.Add(new SimpleUser()
                {
                    No = counter,
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    IsAdmin = await _userManager.IsInRoleAsync(user, roleAdmin)
                });
                counter++;
            }

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(u => u.Username.Contains(searchString)
                                       || u.Email.Contains(searchString)).ToList();
            }
            switch (sortOrder)
            {
                case "username_desc":
                    users = users.OrderByDescending(u => u.Username).ToList();
                    break;
                case "email":
                    users = users.OrderBy(u => u.Email).ToList();
                    break;
                case "email_desc":
                    users = users.OrderByDescending(u => u.Email).ToList();
                    break;
                case "admin":
                    users = users.OrderBy(u => u.IsAdmin).ToList();
                    break;
                case "admin_desc":
                    users = users.OrderByDescending(u => u.IsAdmin).ToList();
                    break;
                default:
                    users = users.OrderBy(u => u.Username).ToList();
                    break;
            }

            int pageSize = 10;

            vm.Users = await PaginatedList<SimpleUser>.CreateAsync(users, pageNumber ?? 1, pageSize);
            return View(vm);
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
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                    return RedirectToAction("Index");
            }
            return View(name);
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            EditRoleViewModel model = new()
            {
                Id = role.Id,
                RoleName = role.Name,

            };

            foreach (var user in _userManager.Users.ToList())
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);

            role.Name = model.RoleName;

            var result = await _roleManager.UpdateAsync(role);

            if (result.Succeeded) { return RedirectToAction("Index"); }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var result = await _roleManager.DeleteAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUsersRoles(UserRoleViewModel model)
        {
            for (int i = 0; i < model.Users.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model.Users[i].Id);

                if (model.Users[i].IsAdmin && !(await _userManager.IsInRoleAsync(user, roleAdmin)))
                {
                    await _userManager.AddToRoleAsync(user, roleAdmin);
                }
                else if (!model.Users[i].IsAdmin && await _userManager.IsInRoleAsync(user, roleAdmin))
                {
                    await _userManager.RemoveFromRoleAsync(user, roleAdmin);
                }
                else
                {
                    continue;
                }
            }

            return RedirectToAction("Index");
        }
    }

}
