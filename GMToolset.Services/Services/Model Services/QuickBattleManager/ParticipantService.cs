using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.QuickBattleManager;
using GMTEntities = GMToolset.Data.Entities.QuickBattleManager;
using GMTModels = GMToolset.Services.Models.QuickBattleManager;

namespace GMToolset.Services.Services.Model_Services.QuickBattleManager
{
    public class ParticipantService : ModelServiceBase<GMTEntities.Participant>, IModelService<GMTModels.Participant>
    {
        public ParticipantService(IRepository<GMTEntities.Participant> repository, IMapper mapper) : base(repository, mapper)
        {

        }

        public void Add(Participant entity)
        {
            _repository.Add(_mapper.Map<GMTEntities.Participant>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Participant> GetAll()
        {
            return _mapper.Map<IEnumerable<GMTModels.Participant>>(_repository.GetAll());
        }

        public Participant GetById(Guid id)
        {
            return _mapper.Map<GMTModels.Participant>(_repository.GetById(id));
        }

        public void Update(Participant entity)
        {
            _repository.Update(_mapper.Map<GMTEntities.Participant>(entity));
        }
    }
}
