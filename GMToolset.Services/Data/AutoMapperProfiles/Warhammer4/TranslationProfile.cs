using AutoMapper;
using GMToolset.Services.Models.Warhammer4;

namespace GMToolset.Services.Data.AutoMapperProfiles.Warhammer4
{
    public class TranslationProfile : Profile
    {
        public TranslationProfile()
        {
            CreateMap<GMToolset.Data.Entities.Warhammer4.Translation, Translation>().ReverseMap();
        }
    }
}
