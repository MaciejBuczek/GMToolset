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

        public int Wounds { get; set; }

        public int Fate { get; set; }

        public int Fortune { get; set; }

        public int Resilience { get; set; }

        public int Resolve { get; set; }

        public string Motivation { get; set; }

        public int ExpCurrent { get; set; }

        public int ExpSpent { get; set; }

        public int Movement { get; set; }

        public CharacterCharacteristics Characteristics { get; set; }
    }
}
