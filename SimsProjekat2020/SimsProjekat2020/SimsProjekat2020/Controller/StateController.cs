using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public class StateController : IController<State, string>
    {
        private readonly IService<State, string> _service;

        public StateController(IService<State,string> service)
        {
            _service = service;
        }
        public State Create(State state) => _service.Create(state);
        public void Delete(State state) => _service.Delete(state);
        public State Get(string id) => _service.Get(id);
        public IEnumerable<State> GetAll() => _service.GetAll();
        public void Update(State state) => _service.Update(state);
    }
}
