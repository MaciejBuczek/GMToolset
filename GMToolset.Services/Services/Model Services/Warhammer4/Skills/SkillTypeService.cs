using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;

using _Entities = GMToolset.Data.Entities.Warhammer4.Character.Skills;
using _Models = GMToolset.Services.Models.Warhammer4.Character.Skills;

namespace GMToolset.Services.Services.Model_Services.Warhammer4.Skills
{
    internal class SkillTypeService : ModelServiceBase<_Entities.SkillType>, IModelService<_Models.SkillType>
    {
        public SkillTypeService(IRepository<_Entities.SkillType> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void Add(_Models.SkillType entity)
        {
            _repository.Add(_mapper.Map<_Entities.SkillType>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<_Models.SkillType> GetAll()
        {
            return _mapper.Map<IEnumerable<_Models.SkillType>>(_repository.GetAll());
        }

        public _Models.SkillType GetById(Guid id)
        {
            return _mapper.Map<_Models.SkillType>(_repository.GetById(id));
        }

        public void Update(_Models.SkillType entity)
        {
            _repository.Update(_mapper.Map<_Entities.SkillType>(entity));
        }
    }
}
