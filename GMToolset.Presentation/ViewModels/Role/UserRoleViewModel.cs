using GMToolset.Presentation.Helpers;
using GMToolset.Presentation.ViewModels.Role.Models;

namespace GMToolset.Presentation.ViewModels.Role
{
    public class UserRoleViewModel
    {
        public PaginatedList<SimpleUser> Users { get; set; }
        public List<SimpleRole> Roles { get; set; } = new ();
    }
}
