using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4.Character
{
    public class CharacterSheet
    {
        [Key]
        public Guid Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Species { get; set; }

        [Required, MaxLength(100)]
        public string Class { get; set; }

        [Required, MaxLength(100)]
        public string Career { get; set; }

        [Required, MaxLength(100), Display(Name = "Carrier Tier")]
        public string CarrierTier { get; set; }

        [Required, Display(Name = "Carrier Path")]
        public string CareerPath { get; set; }

        [Required, MaxLength(100)]
        public string Status { get; set; }

        [MaxLength(100)]
        public string Age { get; set; }

        [MaxLength(100)]
        public string Height { get; set; }

        [MaxLength(100)]
        public string Hair { get; set; }

        [MaxLength(100)]
        public string Eyes { get; set; }

        [Required]
        public int Wounds { get; set; }

        [Required]
        public int Fate { get; set; }

        [Required]
        public int Fortune { get; set; }

        [Required]
        public int Resilience { get; set; }

        [Required]
        public int Resolve { get; set; }

        [Required]
        public string Motivation { get; set; }

        [Required]
        public int ExpCurrent { get; set; }

        [Required]
        public int ExpSpent { get; set; }

        [Required]
        public int Movement { get; set; }

        public List<CharacterCharacteristics> Characteristics { get; set; }

        public List<CharacterSkills> Skills { get; set; }
    }
}
