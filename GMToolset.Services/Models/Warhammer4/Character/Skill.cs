namespace GMToolset.Services.Models.Warhammer4.Character
{
    public enum SkillType
    {
        Base, Advanced, Grouped
    }

    public class Skill
    {
        public Guid Id { get; set; }

        public SkillType Type { get; set; }

        public Translation Name { get; set; }
    }
}
