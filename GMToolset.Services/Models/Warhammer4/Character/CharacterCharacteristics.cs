namespace GMToolset.Services.Models.Warhammer4.Character
{
    public class CharacterCharacteristics
    {
        public Guid Id { get; set; }

        public Characteristic Characteristics { get; set; }

        public int BaseValue { get; set; }

        public int Advancement { get; set; }
    }
}
