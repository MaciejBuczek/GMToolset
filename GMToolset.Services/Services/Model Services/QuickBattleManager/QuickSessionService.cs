using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using GMToolset.Services.Models.QuickBattleManager;
using GMTEntities = GMToolset.Data.Entities.QuickBattleManager;
using GMTModels = GMToolset.Services.Models.QuickBattleManager;

namespace GMToolset.Services.Services.Model_Services.QuickBattleManager
{
    public class QuickSessionService : ModelServiceBase<GMTEntities.QuickSession>, IModelService<GMTModels.QuickSession>
    {
        public QuickSessionService(IRepository<GMTEntities.QuickSession> repository, IMapper mapper) : base(repository, mapper)
        {

        }
        public void Add(QuickSession entity)
        {
            _repository.Add(_mapper.Map<GMTEntities.QuickSession>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<QuickSession> GetAll()
        {
            return _mapper.Map<IEnumerable<GMTModels.QuickSession>>(_repository.GetAll());
        }

        public QuickSession GetById(Guid id)
        {
            return _mapper.Map<GMTModels.QuickSession>(_repository.GetById(id));
        }

        public void Update(QuickSession entity)
        {
            _repository.Update(_mapper.Map<GMTEntities.QuickSession>(entity));
        }
    }
}
