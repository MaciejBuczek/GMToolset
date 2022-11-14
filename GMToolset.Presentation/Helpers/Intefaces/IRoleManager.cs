using GMToolset.Presentation.ViewModels.Role;

namespace GMToolset.Presentation.Helpers.Intefaces
{
    public interface IRoleManager
    {
        Task<UserRoleViewModel> CreateUserRoleViewModel(
            string sortOrder,
            string currentFilter,
            string searchString,
            int? pageNumber);
        Task<bool> CreateRole(string name);
        Task<EditRoleViewModel> GetRoleAndUsers(string roleId);
        Task<bool> UpdateRole(EditRoleViewModel vm);
        Task<bool> DeleteRole(string roleId);
        Task<bool> UpdateUsersRoles(UserRoleViewModel vm);
    }
}
