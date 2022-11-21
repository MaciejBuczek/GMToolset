namespace GMToolset.Services.Models.Warhammer4.Character.Skills
{

    public class Skill
    {
        public Guid Id { get; set; }

        public SkillType Type { get; set; }

        public Translation Name { get; set; }

        public Characteristic Characteristic { get; set; }
    }
}
