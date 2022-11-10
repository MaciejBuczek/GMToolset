using GMToolset.Presentation.ViewModels.Warhammer4.CRUD;
using GMToolset.Services.Models.Warhammer4.Character;

namespace GMToolset.Presentation.ViewModels.Warhammer4
{
    public class CharacteristicManageVM
    {
        public IEnumerable<Characteristic>? Characteristics { get; set; }

        public TranslationCRUD TranslationCRUD { get; set; } = new TranslationCRUD();
    }
}
