using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;

namespace SimsProjekat2020.Controller
{
    public class GuestAccountController : IController<GuestAccount, string>
    {
        private readonly IService<GuestAccount, string> _service;

        public GuestAccountController(IService<GuestAccount, string> service)
        {
            _service = service;
        }
        public GuestAccount Create(GuestAccount guestAccount) => _service.Create(guestAccount);
        public void Delete(GuestAccount guestAccount) => _service.Delete(guestAccount);       
        public GuestAccount Get(string id) => _service.Get(id);        
        public IEnumerable<GuestAccount> GetAll() => _service.GetAll();
        public void Update(GuestAccount guestAccount) => _service.Update(guestAccount);       
    }
}
