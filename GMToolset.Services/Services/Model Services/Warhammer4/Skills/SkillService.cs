using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.Warhammer4.Character;
using GMToolset.Services.Models.Warhammer4.Character.Skills;
using _Entities = GMToolset.Data.Entities.Warhammer4.Character.Skills;
using _Models = GMToolset.Services.Models.Warhammer4.Character.Skills;

namespace GMToolset.Services.Services.Model_Services.Warhammer4.Skills
{
    public class SkillService : ModelServiceBase<_Entities.Skill>, IModelService<_Models.Skill>
    {
        private readonly IModelService<SkillType> _skillTypeService;
        private readonly IModelService<Characteristic> _characteristicService;

        public SkillService(IRepository<_Entities.Skill> repository, IMapper mapper,
            IModelService<SkillType> skilltypeService, IModelService<Characteristic> characteristicService) : base(repository, mapper)
        {
            _skillTypeService = skilltypeService;
            _characteristicService = characteristicService;
        }

        public void Add(_Models.Skill entity)
        {
            var skillType = _skillTypeService.GetById(entity.Type.Id);
            var characteristic = _characteristicService.GetById(entity.Characteristic.Id);
            if(skillType != null && characteristic != null)
            {
                _repository.Add(_mapper.Map<_Entities.Skill>(entity));
            }
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<_Models.Skill> GetAll()
        {
            return _mapper.Map<IEnumerable<_Models.Skill>>(_repository.GetAll());
        }

        public _Models.Skill GetById(Guid id)
        {
            return _mapper.Map<_Models.Skill>(_repository.GetById(id));
        }

        public void Update(_Models.Skill entity)
        {
            _repository.Update(_mapper.Map<_Entities.Skill>(entity));
        }
    }
}
