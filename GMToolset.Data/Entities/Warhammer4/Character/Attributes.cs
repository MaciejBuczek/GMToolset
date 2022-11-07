using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4.Character
{
    public class Attributes
    {
        [Key]
        public Guid Id { get; set; }

        public int WeaponSkill { get; set; }

        public int WeaponSkillAdv { get; set; }

        public int BallisticSkill { get; set; }

        public int BallisticSkillAdv { get; set; }

        public int Strength { get; set; }

        public int StrengthAdv { get; set; }

        public int Toughness { get; set; }

        public int ToughnessAdv { get; set; }

        public int Initiattive { get; set; }

        public int InitiattiveAdv { get; set; }

        public int Agility { get; set; }

        public int AgilityAdv { get; set; }

        public int Dexterity { get; set; }

        public int DexterityAdv { get; set; }

        public int Intelligence { get; set; }

        public int IntelligenceAdv { get; set; }

        public int Willpower { get; set; }

        public int WillpowerAdv { get; set; }

        public int Fellowship { get; set; }

        public int FellowshipAdv { get; set; }
    }
}
