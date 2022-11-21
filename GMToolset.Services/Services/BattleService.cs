using GMToolset.Services.Helpers.Extensions;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.QuickBattleManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMToolset.Services.Services
{
    public class BattleService : IBattleService
    {
        private List<Participant> _participants;
        private PriorityQueue<Participant, int> _battleQueue;

        public BattleService(List<Participant> participants)
        {
            _participants = participants;
            _battleQueue = new PriorityQueue<Participant, int>();
        }

        public void AddParticipant(Participant participant)
        {
            if (participant == null)
                throw new ArgumentNullException(nameof(participant));

            _battleQueue.Enqueue(participant, participant.Initiative);
        }

        public void EnqueueParticipants(IEnumerable<Participant> participants)
        {
            _participants.ForEach(p => _battleQueue.Enqueue(p, p.Initiative));
        }

        public List<Participant> GetParticipants()
        {
            EnqueueParticipants(_participants);
            var dequeued = new List<Participant>();
            while(_battleQueue.TryDequeue(out var participant, out _))
            {
                dequeued.Add(participant);
            }

            return dequeued;
        }

        public void RemoveParticipant(Guid participantId)
        {
            if (participantId == Guid.Empty)
                throw new ArgumentNullException(nameof(participantId));

            _participants.Remove(_participants.First(p => p.Id == participantId));
        }

        public void UpdateParticipant(Participant participant)
        {
            if (participant == null)
                throw new ArgumentNullException(nameof(participant));

            _participants.Where(p => p.Id == participant.Id).First().Update(participant);
        }
    }
}
