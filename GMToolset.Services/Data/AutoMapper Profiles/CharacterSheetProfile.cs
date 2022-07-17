using AutoMapper;
using GMToolset.Services.Models.Warhammer4;

namespace GMToolset.Services.Data.AutoMapperProfiles
{
    public class CharacterSheetProfile : Profile
    {
        public CharacterSheetProfile()
        {
            CreateMap<GMToolset.Data.Entities.Warhammer4.CharacterSheet, CharacterSheet>().ReverseMap();
        }
    }
}
