using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using GMTEntities = GMToolset.Data.Entities.Warhammer4;
using GMTModels = GMToolset.Services.Models.Warhammer4;

namespace GMToolset.Services.Services.Model_Services.Warhammer4
{
    public class CharacterSheetService : ModelServiceBase<GMTEntities.CharacterSheet>, IModelService<GMTModels.CharacterSheet>
    {
        public CharacterSheetService(IRepository<GMTEntities.CharacterSheet> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void Add(GMTModels.CharacterSheet entity)
        {
            _repository.Add(_mapper.Map<GMTEntities.CharacterSheet>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<GMTModels.CharacterSheet> GetAll()
        {
            return _mapper.Map<IEnumerable<GMTModels.CharacterSheet>>(_repository.GetAll());
        }

        public GMTModels.CharacterSheet GetById(Guid id)
        {
            return _mapper.Map<GMTModels.CharacterSheet>(_repository.GetById(id));
        }

        public void Update(GMTModels.CharacterSheet entity)
        {
            _repository.Update(_mapper.Map<GMTEntities.CharacterSheet>(entity));
        }
    }
}
