using AutoMapper;

namespace GMToolset.Services.Data.AutoMapperProfiles
{
    public class CharacterSheetProfile : Profile
    {
        public CharacterSheetProfile()
        {
            CreateMap<GMToolset.Data.Entities.Warhammer4.CharacterSheet, Models.CharacterSheet>().ReverseMap();
        }
    }
}
