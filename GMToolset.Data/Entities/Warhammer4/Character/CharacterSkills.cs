using System.ComponentModel.DataAnnotations;
using GMToolset.Data.Entities.Warhammer4.Character.Skills;

namespace GMToolset.Data.Entities.Warhammer4.Character
{
    public class CharacterSkills
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Skill Skill { get; set; }

        [Required]
        public int BaseValue { get; set; }

        [Required]
        public int Advancement { get; set; }
    }
}
