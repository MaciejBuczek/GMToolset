using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4.Character.Skills
{
    public class SkillType
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Translation Name { get; set; }
    }
}
