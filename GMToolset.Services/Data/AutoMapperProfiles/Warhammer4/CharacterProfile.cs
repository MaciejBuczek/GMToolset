using AutoMapper;
using GMToolset.Data.Entities.Warhammer4.Character.Skills;
using GMToolset.Services.Models.Warhammer4.Character;
using GMToolset.Services.Models.Warhammer4.Character.Skills;

namespace GMToolset.Services.Data.AutoMapperProfiles.Warhammer4
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterSheet, CharacterSheet>().ReverseMap();

            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.Skills.Skill, Skill>().ReverseMap();
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.Skills.SkillType, SkillType>().ReverseMap();

            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.Characteristic, Characteristic>().ReverseMap();

            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterSkills, CharacterSkills>().ReverseMap();
            CreateMap<GMToolset.Data.Entities.Warhammer4.Character.CharacterCharacteristics, Characteristics>().ReverseMap();
        }
    }
}
