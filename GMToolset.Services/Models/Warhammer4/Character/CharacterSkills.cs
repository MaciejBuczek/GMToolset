using GMToolset.Services.Models.Warhammer4.Character.Skills;

namespace GMToolset.Services.Models.Warhammer4.Character
{
    public class CharacterSkills
    {
        public Guid Id { get; set; }

        public Skill Skill { get; set; }

        public int BaseValue { get; set; }

        public int Advancement { get; set; }
    }
}
