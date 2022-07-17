using AutoMapper;
using GMToolset.Data.Entities.Warhammer4;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using Entities = GMToolset.Data.Entities.Warhammer4;

namespace GMToolset.Services.Services.Model_Services
{
    public class CharacterSheetService : ModelServiceBase<Entities.CharacterSheet>, IModelService<CharacterSheet>
    {
        public CharacterSheetService(IRepository<CharacterSheet> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void Add(CharacterSheet entity)
        {
            _repository.Add(_mapper.Map<Entities.CharacterSheet>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<CharacterSheet> GetAll()
        {
            return _mapper.Map<IEnumerable<CharacterSheet>>(_repository.GetAll());
        }

        public CharacterSheet GetById(Guid id)
        {
            return _mapper.Map<CharacterSheet>(_repository.GetById(id));
        }

        public void Update(CharacterSheet entity)
        {
            _repository.Update(_mapper.Map<Entities.CharacterSheet>(entity);
        }
    }
}
