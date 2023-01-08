using GMToolset.Services.Models.Warhammer4.Character;
using GMToolset.Services.Models.Warhammer4.Character.Skills;

namespace GMToolset.Presentation.ViewModels.Warhammer4.CRUD
{
    public class SkillManageVM : TranslationBasedManageVM<Skill>
    {

        public Guid CharacteristicId { get; set; }

        public Guid SkillTypeId { get; set; }

        public IEnumerable<Characteristic>? Characteristics { get; set; }

        public IEnumerable<Skill>? Skills { get; set; }

        public IEnumerable<SkillType>? SkillTypes { get; set; }
    }
}
