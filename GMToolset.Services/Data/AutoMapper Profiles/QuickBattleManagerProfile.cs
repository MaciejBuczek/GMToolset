using AutoMapper;
using GMToolset.Services.Models.QuickBattleManager;

namespace GMToolset.Services.Data.AutoMapper_Profiles
{
    public class QuickBattleManagerProfile : Profile
    {
        public QuickBattleManagerProfile()
        {
            CreateMap<GMToolset.Data.Entities.QuickBattleManager.Participant, Participant>().ReverseMap();
            CreateMap<GMToolset.Data.Entities.QuickBattleManager.QuickSession, QuickSession>().ReverseMap();
        }
    }
}
