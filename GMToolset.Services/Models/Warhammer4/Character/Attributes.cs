using System.ComponentModel;

namespace GMToolset.Services.Models.Warhammer4.Character
{
    public class Attributes
    {
        public Guid Id { get; set; }

        [DisplayName("WS")]
        public int WeaponSkill { get; set; }

        public int WeaponSkillAdv { get; set; }

        [DisplayName("BS")]
        public int BallisticSkill { get; set; }

        public int BallisticSkillAdv { get; set; }

        [DisplayName("S")]
        public int Strength { get; set; }

        public int StrengthAdv { get; set; }

        [DisplayName("T")]
        public int Toughness { get; set; }

        public int ToughnessAdv { get; set; }

        [DisplayName("I")]
        public int Initiattive { get; set; }

        public int InitiattiveAdv { get; set; }

        [DisplayName("Ag")]
        public int Agility { get; set; }

        public int AgilityAdv { get; set; }

        [DisplayName("Dex")]
        public int Dexterity { get; set; }

        public int DexterityAdv { get; set; }

        [DisplayName("Int")]
        public int Intelligence { get; set; }

        public int IntelligenceAdv { get; set; }

        [DisplayName("WP")]
        public int Willpower { get; set; }

        public int WillpowerAdv { get; set; }

        [DisplayName("Fel")]
        public int Fellowship { get; set; }

        public int FellowshipAdv { get; set; }
    }
}
