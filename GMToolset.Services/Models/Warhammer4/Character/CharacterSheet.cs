namespace GMToolset.Services.Models.Warhammer4.Character
{
    public class CharacterSheet
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string Class { get; set; }

        public string Career { get; set; }

        public string CarrierTier { get; set; }

        public string CareerPath { get; set; }

        public string Status { get; set; }

        public string Age { get; set; }

        public string Height { get; set; }

        public string Hair { get; set; }

        public string Eyes { get; set; }

        public int Wounds { get; set; }

        public int Fate { get; set; }

        public int Fortune { get; set; }

        public int Resilience { get; set; }

        public int Resolve { get; set; }

        public string Motivation { get; set; }

        public int ExpCurrent { get; set; }

        public int ExpSpent { get; set; }

        public int Movement { get; set; }

        public Characteristics Characteristics { get; set; }
    }
}