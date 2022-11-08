using AutoMapper;
using GMToolset.Services.Models.Warhammer4.Character;

namespace GMToolset.Services.Data.AutoMapperProfiles
{
    public class CharacterSheetProfile : Profile
    {
        public CharacterSheetProfile()
        {
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterSheet, CharacterSheet>().ReverseMap();
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterCharacteristics, Characteristics>().ReverseMap();
        }
    }
}
