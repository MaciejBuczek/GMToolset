using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;

using _Entities = GMToolset.Data.Entities.Warhammer4.Character;
using _Models = GMToolset.Services.Models.Warhammer4.Character;

namespace GMToolset.Services.Services.Model_Services.Warhammer4
{
    public class CharacterSheetService : ModelServiceBase<_Entities.CharacterSheet>, IModelService<_Models.CharacterSheet>
    {
        public CharacterSheetService(IRepository<_Entities.CharacterSheet> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void Add(_Models.CharacterSheet entity)
        {
            _repository.Add(_mapper.Map<_Entities.CharacterSheet>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<_Models.CharacterSheet> GetAll()
        {
            return _mapper.Map<IEnumerable<_Models.CharacterSheet>>(_repository.GetAll());
        }

        public _Models.CharacterSheet GetById(Guid id)
        {
            return _mapper.Map<_Models.CharacterSheet>(_repository.GetById(id));
        }

        public void Update(_Models.CharacterSheet entity)
        {
            _repository.Update(_mapper.Map<_Entities.CharacterSheet>(entity));
        }
    }
}
