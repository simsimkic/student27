using Model;
using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    public class GuestAccountService : IService<GuestAccount, string>
    {
        private readonly IGuestAccount _repository;
        public GuestAccountService(IGuestAccount repository)
        {
            _repository = repository;
        }
        public GuestAccount Create(GuestAccount guestAccount) => _repository.Create(guestAccount);       

        public void Delete(GuestAccount guestAccount) => _repository.Delete(guestAccount);
        public GuestAccount Get(string id) => _repository.Get(id);
        public IEnumerable<GuestAccount> GetAll() => _repository.GetAll();

        public void Update(GuestAccount guestAccount) => _repository.Update(guestAccount);
    }
}
