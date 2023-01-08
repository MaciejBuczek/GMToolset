namespace GMToolset.Services.Models.Warhammer4.Character.Skills
{

    public class Skill
    {
        public Guid Id { get; set; }

        public Guid SkillTypeId { get; set; }
        public SkillType SkillType { get; set; }


        public Guid NameId { get; set; }
        public Translation Name { get; set; }


        public Guid CharacteristicId { get; set; }
        public Characteristic Characteristic { get; set; }
    }
}
