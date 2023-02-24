using Model;
using SimsProjekat2020.Repository;
using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
   public class UserService : IService<User, string>
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public User Create(User user) => _repository.Create(user);
        
        public void Delete(User user) => _repository.Delete(user);

        public User Get(string id) => _repository.Get(id);

        public IEnumerable<User> GetAll() => _repository.GetAll();

        public void Update(User user) => _repository.Update(user);
    }
}
