using GMToolset.Data.Entities.Warhammer4.Character.Skills;
using GMToolset.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GMToolset.Data.Repositories.Warhammer4.Character.Skills
{
    public class SkillTypeRepository : RepositoryBase, IRepository<SkillType>
    {
        public SkillTypeRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public void Add(SkillType entity)
        {
            _appDbContext.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _appDbContext.SkillTypes.Find(id);
            if (entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public bool Exists(Guid id)
        {
            return _appDbContext.SkillTypes.Find(id) != null;
        }

        public IEnumerable<SkillType> GetAll()
        {
            return _appDbContext.SkillTypes.Include(x => x.Name).AsEnumerable();
        }

        public SkillType GetById(Guid id)
        {
            return _appDbContext.SkillTypes.Where(x => x.Id == id).Include(x => x.Name).FirstOrDefault();
        }

        public void Update(SkillType entity)
        {
            if (_appDbContext.SkillTypes.Find(entity.Id) != null)
            {
                _appDbContext.Update(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
