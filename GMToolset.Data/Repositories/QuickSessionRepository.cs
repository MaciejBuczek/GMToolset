using GMToolset.Data.Entities.QuickBattleManager;
using GMToolset.Data.Repositories.Interfaces;

namespace GMToolset.Data.Repositories
{
    public class QuickSessionRepository : RepositoryBase, IRepository<QuickSession>
    {
        public QuickSessionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public void Add(QuickSession entity)
        {
            _appDbContext.Add(entity);
        }

        public void Delete(Guid id)
        {
            var entity = _appDbContext.QuickSessions.Find(id);
            if (entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public bool Exists(Guid id)
        {
            return _appDbContext.QuickSessions.Find(id) == null;
        }

        public IEnumerable<QuickSession> GetAll()
        {
            return _appDbContext.QuickSessions.AsEnumerable();
        }

        public QuickSession GetById(Guid id)
        {
            return _appDbContext.QuickSessions.Find(id);
        }

        public void Update(QuickSession entity)
        {
            if (_appDbContext.QuickSessions.Find(entity.Id) != null)
            {
                _appDbContext.Update(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
