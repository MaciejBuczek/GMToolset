using GMToolset.Data.Entities.Warhammer4.Character;
using GMToolset.Data.Repositories.Interfaces;

namespace GMToolset.Data.Repositories
{
    public class CharacterSheetRepository : RepositoryBase, IRepository<CharacterSheet>
    {
        public CharacterSheetRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public void Add(CharacterSheet entity)
        {
            _appDbContext.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _appDbContext.CharacterSheets.Find(id);
            if(entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<CharacterSheet> GetAll()
        {
            return _appDbContext.CharacterSheets.AsEnumerable();
        }

        public CharacterSheet GetById(Guid id)
        {
            return _appDbContext.CharacterSheets.Find(id);
        }

        public void Update(CharacterSheet entity)
        {
            if(_appDbContext.CharacterSheets.Find(entity.Id) != null)
            {
                _appDbContext.Update(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
