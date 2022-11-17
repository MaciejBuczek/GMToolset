using GMToolset.Services.Models.QuickBattleManager;

namespace GMToolset.Services.Interfaces
{
    public interface IBattleService
    {
        void EnqueueParticipants(IEnumerable<Participant> participants);

        List<Participant> GetParticipants();

        void AddParticipant(Participant participant);

        void RemoveParticipant(Guid participantId);

        void UpdateParticipant(Participant participant);
    }
}
