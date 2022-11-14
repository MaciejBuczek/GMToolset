using AutoMapper;
using GMToolset.Data.Entities.Warhammer4;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;

using _Entities = GMToolset.Data.Entities.Warhammer4;
using _Models = GMToolset.Services.Models.Warhammer4;

namespace GMToolset.Services.Services.Model_Services.Warhammer4
{
    public class TranslationService : ModelServiceBase<_Entities.Translation>, IModelService<_Models.Translation>
    {
        public TranslationService(IRepository<Translation> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void Add(_Models.Translation entity)
        {
            _repository.Add(_mapper.Map<_Entities.Translation>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<_Models.Translation> GetAll()
        {
            return _mapper.Map<IEnumerable<_Models.Translation>>(_repository.GetAll());
        }

        public _Models.Translation GetById(Guid id)
        {
            return _mapper.Map<_Models.Translation>(_repository.GetById(id));
        }

        public void Update(_Models.Translation entity)
        {
            _repository.Update(_mapper.Map<_Entities.Translation>(entity));
        }
    }
}
