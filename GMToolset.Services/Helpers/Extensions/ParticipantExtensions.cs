using GMToolset.Services.Models.QuickBattleManager;

namespace GMToolset.Services.Helpers.Extensions
{
    public static class ParticipantExtensions
    {
        public static void Update(this Participant current, Participant other)
        {
            if (other == null)
                throw new ArgumentNullException(nameof(other));

            current.MaxHp = other.MaxHp;
            current.CurrentHp = other.CurrentHp;
            current.MaxMp = other.MaxMp;
            current.CurrentMp = other.CurrentMp;
            current.MaxSt = other.MaxSt;
            current.CurrentSt = other.CurrentSt;
            current.Initiative = other.Initiative;
            current.DamagePerRound = other.DamagePerRound;
        }
    }
}
