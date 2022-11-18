using GMToolset.Data.Entities.Warhammer4.Character.Skills;
using GMToolset.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GMToolset.Data.Repositories.Warhammer4.Character.Skills
{
    public class SkillRepository : RepositoryBase, IRepository<Skill>
    {
        public SkillRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public void Add(Skill entity)
        {
            _appDbContext.Add(entity);
            _appDbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = _appDbContext.Skills.Find(id);
            if (entity != null)
            {
                _appDbContext.Remove(entity);
                _appDbContext.SaveChanges();
            }
        }

        public IEnumerable<Skill> GetAll()
        {
            return _appDbContext.Skills.Include(x => x.Name).AsEnumerable();
        }

        public Skill GetById(Guid id)
        {
            return _appDbContext.Skills.Where(x => x.Id == id).Include(x => x.Name).FirstOrDefault();
        }

        public void Update(Skill entity)
        {
            if (_appDbContext.Skills.Find(entity.Id) != null)
            {
                _appDbContext.Update(entity);
                _appDbContext.SaveChanges();
            }
        }
    }
}
