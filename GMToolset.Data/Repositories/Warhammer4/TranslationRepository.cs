using GMToolset.Data.Entities.Warhammer4;
using GMToolset.Data.Repositories.Interfaces;

namespace GMToolset.Data.Repositories.Warhammer4
{
    public class TranslationRepository : RepositoryBase, IRepository<Translation>
    {
        public TranslationRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public void Add(Translation entity)
        {
            _appDbContext.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _appDbContext.Translations.Find(id);
            if (entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<Translation> GetAll()
        {
            return _appDbContext.Translations.AsEnumerable();
        }

        public Translation GetById(Guid id)
        {
            return _appDbContext.Translations.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Translation entity)
        {
            var dbEntity = _appDbContext.Translations.Find(entity.Id);
            if (dbEntity != null)
            {
                dbEntity.ContentPl = entity.ContentPl;
                dbEntity.ContentEng = entity.ContentEng;
                _appDbContext.Update(dbEntity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
