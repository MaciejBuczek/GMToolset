using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4.Character.Skills
{
    public class Skill
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public SkillType Type { get; set; }

        [Required]
        public Translation Name { get; set; }

        [Required]
        public Characteristic Characteristic { get; set; }
    }
}
