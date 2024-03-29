﻿using GMToolset.Presentation.Helpers.Intefaces;
using GMToolset.Presentation.ViewModels.Role;
using GMToolset.Presentation.ViewModels.Role.Models;
using Microsoft.AspNetCore.Identity;

namespace GMToolset.Presentation.Helpers.Managers
{
    public class RoleControllerManager : IRoleControllerManager
    {
        #region consts
        const string roleAdmin = "Admin";
        #endregion

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RoleControllerManager(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<UserRoleViewModel> CreateUserRoleViewModel(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber)
        {
            var vm = new UserRoleViewModel();
            int pageSize = 10;

            foreach (var role in _roleManager.Roles)
            {
                vm.Roles.Add(new SimpleRole()
                {
                    Id = role.Id,
                    RoleName = role.Name
                });
            }

            var users = new List<SimpleUser>();

            var identityUsers = new PaginatedList<IdentityUser>(_userManager.Users.AsEnumerable(), pageNumber ?? 1, pageSize);
            foreach (var user in identityUsers.Items)
            {
                users.Add(new SimpleUser()
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Email = user.Email,
                    IsAdmin = await _userManager.IsInRoleAsync(user, roleAdmin)
                });
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

            vm.Users = new PaginatedList<SimpleUser>(users, pageNumber ?? 1, pageSize);

            return vm;
        }
        public async Task<bool> CreateRole(string name)
        {
            var result = await _roleManager.CreateAsync(new IdentityRole(name));
            return result.Succeeded;
        }
        public async Task<EditRoleViewModel> GetRoleAndUsers(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            EditRoleViewModel vm = new()
            {
                Id = role.Id,
                RoleName = role.Name,

            };

            foreach (var user in _userManager.Users.ToList())
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    vm.Users.Add(user);
                }
            }
            return vm;
        }
        public async Task<bool> UpdateRole(EditRoleViewModel vm)
        {
            var role = await _roleManager.FindByIdAsync(vm.Id);

            role.Name = vm.RoleName;

            var result = await _roleManager.UpdateAsync(role);

            return result.Succeeded;
        }
        public async Task<bool> DeleteRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);

            var result = await _roleManager.DeleteAsync(role);

            return result.Succeeded;
        }
        public async Task<bool> UpdateUsersRoles(UserRoleViewModel vm)
        {
            try
            {
                foreach (var simpleUser in vm.Users.Items)
                {
                    var user = await _userManager.FindByIdAsync(simpleUser.Id);

                    if (simpleUser.IsAdmin && !(await _userManager.IsInRoleAsync(user, roleAdmin)))
                    {
                        await _userManager.AddToRoleAsync(user, roleAdmin);
                    }
                    else if (!simpleUser.IsAdmin && await _userManager.IsInRoleAsync(user, roleAdmin))
                    {
                        await _userManager.RemoveFromRoleAsync(user, roleAdmin);
                    }
                    else
                    {
                        continue;
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
