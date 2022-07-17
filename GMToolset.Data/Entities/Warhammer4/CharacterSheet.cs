using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4
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
        [Required, MaxLength(100), Display(Name = "Carrier Path")]
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
        public int WeaponSkill { get; set; }
        public int WeaponSkillAdv { get; set; }
        [Required]
        public int BallisticSkill { get; set; }
        public int BallisticSkillAdv { get; set; }
        [Required]
        public int Strength { get; set; }
        public int StrengthAdv { get; set; }
        [Required]
        public int Toughness { get; set; }
        public int ToughnessAdv { get; set; }
        [Required]
        public int Initiattive { get; set; }
        public int InitiattiveAdv { get; set; }
        [Required]
        public int Agility { get; set; }
        public int AgilityAdv { get; set; }
        [Required]
        public int Dexterity { get; set; }
        public int DexterityAdv { get; set; }
        [Required]
        public int Intelligence { get; set; }
        public int IntelligenceAdv { get; set; }
        [Required]
        public int Willpower { get; set; }
        public int WillpowerAdv { get; set; }
        [Required]
        public int Fellowship { get; set; }
        public int FellowshipAdv { get; set; }
        public int Wounds { get; set; }
        public int Fate { get; set; }
        public int Fortune { get; set; }
        public int Resilience { get; set; }
        public int Resolve { get; set; }
        public string Motivation { get; set; }
        public int ExpCurrent { get; set; }
        public int ExpSpent { get; set; }
        public int ExpTotal { get; set; }
        public int Movement { get; set; }
        public int Walk { get; set; }
        public int Run { get; set; }
    }
}
