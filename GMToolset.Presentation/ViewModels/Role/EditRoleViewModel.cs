using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace GMToolset.Presentation.ViewModels.Role
{
    public class EditRoleViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Role")]
        [Required(ErrorMessage = "Role name is required.")]
        public string RoleName { get; set; }
        public List<IdentityUser> Users { get; set; } = new();
    }
}
