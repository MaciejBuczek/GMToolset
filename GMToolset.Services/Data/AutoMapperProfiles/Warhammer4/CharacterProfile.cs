using AutoMapper;

using _Entities = GMToolset.Data.Entities.Warhammer4.Character;
using _Models = GMToolset.Services.Models.Warhammer4.Character;

namespace GMToolset.Services.Data.AutoMapperProfiles.Warhammer4
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<_Entities.CharacterSheet, _Models.CharacterSheet>().ReverseMap();

            CreateMap<_Entities.Skills.Skill, _Models.Skills.Skill>().ReverseMap();
            CreateMap<_Entities.Skills.SkillType, _Models.Skills.SkillType>().ReverseMap();

            CreateMap<_Entities.Characteristic, _Models.Characteristic>().ReverseMap();

            CreateMap<_Entities.CharacterSkills, _Models.CharacterSkills>().ReverseMap();
            CreateMap<_Entities.CharacterCharacteristics, _Models.Characteristics>().ReverseMap();
        }
    }
}
