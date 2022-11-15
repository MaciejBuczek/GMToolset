using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GMToolset.Presentation.ViewModels.Role.Models
{
    public class SimpleRole
    {
        public string Id { get; set; }
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
