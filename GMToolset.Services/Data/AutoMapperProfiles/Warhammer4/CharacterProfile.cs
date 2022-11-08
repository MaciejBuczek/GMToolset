using AutoMapper;
using GMToolset.Services.Models.Warhammer4.Character;

namespace GMToolset.Services.Data.AutoMapperProfiles.Warhammer4
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterSheet, CharacterSheet>().ReverseMap();

            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.Skill, Skill>().ReverseMap();
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.SkillType, SkillType>().ReverseMap();

            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.Characteristic, Characteristic>().ReverseMap();

            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterSkills, CharacterSkills>().ReverseMap();
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterCharacteristics, Characteristics>().ReverseMap();
        }
    }
}
