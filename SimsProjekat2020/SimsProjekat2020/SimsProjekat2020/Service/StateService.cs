using Model;
using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    public class StateService : IService<State, string>
    {
        private readonly IStateRepository _repository;

        public StateService(IStateRepository repository)
        {
            _repository = repository;
        }

        public State Create(State state) => _repository.Create(state);
        public void Delete(State state) => _repository.Delete(state);
        public State Get(string id) => _repository.Get(id);
        public IEnumerable<State> GetAll() => _repository.GetAll();
        public void Update(State state) => _repository.Update(state);
    }
}
