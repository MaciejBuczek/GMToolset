using System.ComponentModel.DataAnnotations;

namespace GMToolset.Data.Entities.Warhammer4.Character
{
    public class CharacterCharacteristics
    {
        [Key]
        public Guid Id { get; set; }

        public List<Characteristic> Characteristics { get; set; }
    }
}
