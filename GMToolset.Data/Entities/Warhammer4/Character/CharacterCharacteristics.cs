using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4.Character
{
    public class CharacterCharacteristics
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Characteristic Characteristics { get; set; }

        [Required]
        public int BaseValue { get; set; }

        [Required]
        public int Advancement { get; set; }
    }
}
