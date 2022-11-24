using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.QuickBattleManager
{
    public class Participant
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Display(Name = "Max Health")]
        public int MaxHp { get; set; }
        [Display(Name = "Current Health")]
        public int CurrentHp { get; set; }
        [Display(Name = "Is mana applicable?")]
        public bool IsMpApplicable { get; set; }
        [Display(Name = "Max Mana")]
        public int MaxMp { get; set; }
        [Display(Name = "Current Mana")]
        public int CurrentMp { get; set; }
        [Display(Name = "Is stamina applicable?")]
        public bool IsStApplicable { get; set; }
        [Display(Name = "Max Stamina")]
        public int MaxSt { get; set; }
        [Display(Name = "Current Stamina")]
        public int CurrentSt { get; set; }
        public int Initiative { get; set; }
        [Display(Name = "Damage taken every round")]
        public int DamagePerRound { get; set; }
        [Display(Name = "Extra informations")]
        public string ExtraInfo { get; set; }
        public string Image { get; set; }
        [Required]
        public QuickSession QuickSession { get; set; }
    }
}
