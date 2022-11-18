using GMToolset.Services.Models.Warhammer4.Character.Skills;
using System.ComponentModel.DataAnnotations;

namespace GMToolset.Presentation.ViewModels.Warhammer4.CRUD
{
    public class SkillManageVM
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ContentPl { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string ContentEng { get; set; } = string.Empty;

        public Guid SkillType { get; set; }

        public Guid CharacteristicId { get; set; }

        public IEnumerable<Skill>? Skills { get; set; }
    }
}
