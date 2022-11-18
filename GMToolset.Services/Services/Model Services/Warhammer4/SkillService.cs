using AutoMapper;
using GMToolset.Data.Entities.Warhammer4.Character.Skills;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4.Character.Skills;
using _Entities = GMToolset.Data.Entities.Warhammer4.Character;
using _Models = GMToolset.Services.Models.Warhammer4.Character;

namespace GMToolset.Services.Services.Model_Services.Warhammer4
{
    public class SkillService : ModelServiceBase<Skill>, IModelService<_Models.Skills.Skill>
    {
        public SkillService(IRepository<Skill> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void Add(_Models.Skills.Skill entity)
        {
            _repository.Add(_mapper.Map<Skill>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<_Models.Skills.Skill> GetAll()
        {
            return _mapper.Map<IEnumerable<_Models.Skills.Skill>>(_repository.GetAll());
        }

        public _Models.Skills.Skill GetById(Guid id)
        {
            return _mapper.Map<_Models.Skills.Skill>(_repository.GetById(id));
        }

        public void Update(_Models.Skills.Skill entity)
        {
            _repository.Update(_mapper.Map<Skill>(entity));
        }
    }
}
