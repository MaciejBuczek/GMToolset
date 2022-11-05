using GMToolset.Data.Entities.QuickBattleManager;
using GMToolset.Data.Repositories.Interfaces;

namespace GMToolset.Data.Repositories
{
    public class ParticipantRepository : RepositoryBase, IRepository<Participant>
    {
        public ParticipantRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public void Add(Participant entity)
        {
            _appDbContext.Add(entity);
        }

        public void Delete(Guid id)
        {
            var entity = _appDbContext.Participant.Find(id);
            if (entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<Participant> GetAll()
        {
            return _appDbContext.Participant.AsEnumerable();
        }

        public Participant GetById(Guid id)
        {
            return _appDbContext.Participant.Find(id);
        }

        public void Update(Participant entity)
        {
            if (_appDbContext.Participant.Find(entity.Id) != null)
            {
                _appDbContext.Update(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
