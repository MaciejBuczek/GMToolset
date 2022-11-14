using GMToolset.Data.Entities.Warhammer4.Character;
using GMToolset.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GMToolset.Data.Repositories.Warhammer4.Character
{
    public class CharacteristicRepository : RepositoryBase, IRepository<Characteristic>
    {
        public CharacteristicRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public void Add(Characteristic entity)
        {
            _appDbContext.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _appDbContext.Characteristics.Find(id);
            if (entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<Characteristic> GetAll()
        {
            return _appDbContext.Characteristics.Include(x => x.Name).AsEnumerable();
        }

        public Characteristic GetById(Guid id)
        {
            return _appDbContext.Characteristics.Where(x => x.Id == id).Include(x => x.Name).FirstOrDefault();
        }

        public void Update(Characteristic entity)
        {
            if (_appDbContext.Characteristics.Find(entity.Id) != null)
            {
                _appDbContext.Update(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
