using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;

namespace GMToolset.Services.Services.Model_Services
{
    public class ModelServiceBase<T>
    {
        protected readonly IRepository<T> _repository;
        protected readonly IMapper _mapper;

        public ModelServiceBase(IRepository<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool Exists (Guid id)
        {
            return _repository.Exists(id);
        }
    }
}
