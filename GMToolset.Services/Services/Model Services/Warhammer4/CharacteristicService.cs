using AutoMapper;
using GMToolset.Data.Repositories.Interfaces;
using GMToolset.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _Entities = GMToolset.Data.Entities.Warhammer4.Character;
using _Models = GMToolset.Services.Models.Warhammer4.Character;

namespace GMToolset.Services.Services.Model_Services.Warhammer4
{
    public class CharacteristicService : ModelServiceBase<_Entities.Characteristic>, IModelService<_Models.Characteristic>
    {
        public CharacteristicService(IRepository<_Entities.Characteristic> repository, IMapper mapper) : base(repository, mapper)
        {
        }

        public void Add(_Models.Characteristic entity)
        {
            _repository.Add(_mapper.Map<_Entities.Characteristic>(entity));
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<_Models.Characteristic> GetAll()
        {
            return _mapper.Map<IEnumerable<_Models.Characteristic>>(_repository.GetAll());
        }

        public _Models.Characteristic GetById(Guid id)
        {
            return _mapper.Map<_Models.Characteristic>(_repository.GetById(id));
        }

        public void Update(_Models.Characteristic entity)
        {
            _repository.Update(_mapper.Map<_Entities.Characteristic>(entity));
        }
    }
}
