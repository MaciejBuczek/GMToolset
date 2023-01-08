using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMToolset.Data.Entities.Warhammer4.Character.Skills
{
    public class Skill
    {
        [Key]
        public Guid Id { get; set; }


        [Required]
        [ForeignKey("SkillTypeId")]
        public Guid SkillTypeId { get; set; }
        [Required]
        public SkillType SkillType { get; set; }

        [Required]
        [ForeignKey("Name")]
        public Guid NameId { get; set; }
        [Required]
        public Translation Name { get; set; }

        [Required]
        [ForeignKey("Characteristic")]
        public Guid CharacteristicId { get; set; }
        [Required]
        public Characteristic Characteristic { get; set; }
    }
}
