using GMToolset.Data.Entities.Warhammer4.Character;
using GMToolset.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GMToolset.Data.Repositories.Warhammer4.Character
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
            if (entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public bool Exists(Guid id)
        {
            return _appDbContext.CharacterSheets.Find(id) != null;
        }

        public IEnumerable<CharacterSheet> GetAll()
        {
            return _appDbContext.CharacterSheets.Include(x => x.Characteristics).AsEnumerable();
        }

        public CharacterSheet GetById(Guid id)
        {
            return _appDbContext.CharacterSheets.Where(x => x.Id == id).Include(x => x.Characteristics).FirstOrDefault();
        }

        public void Update(CharacterSheet entity)
        {
            if (_appDbContext.CharacterSheets.Find(entity.Id) != null)
            {
                _appDbContext.Update(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
