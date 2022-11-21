using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4;
using _Entities = GMToolset.Data.Entities.Warhammer4.Character.Skills;
using _Models = GMToolset.Services.Models.Warhammer4.Character.Skills;

namespace GMToolset.Services.Services.Model_Services.Warhammer4.Skills
{
    public class SkillTypeService : ModelServiceBase<_Entities.SkillType>, IModelService<_Models.SkillType>
    {
        private readonly IModelService<Translation> _translationService;

        public SkillTypeService(IRepository<_Entities.SkillType> repository, IMapper mapper, IModelService<Translation> translationService) : base(repository, mapper)
        {
            _translationService = translationService;
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
            var skillType = GetById(entity.Id);

            skillType.Name.ContentPl = entity.Name.ContentPl;
            skillType.Name.ContentEng = entity.Name.ContentEng;

            _translationService.Update(skillType.Name);
        }
    }
}
