using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
   public class UserController : IController<User, string>
    {
        private readonly IService<User, string> _service;
       
        public UserController(IService<User, string> service)
        {
            _service = service;
        }

        public User Create(User user) => _service.Create(user);
        public void Delete(User user) => _service.Delete(user);
        public User Get(string id) => _service.Get(id);       
        public IEnumerable<User> GetAll() => _service.GetAll();
        public void Update(User user) => _service.Update(user);
        
    }
}
