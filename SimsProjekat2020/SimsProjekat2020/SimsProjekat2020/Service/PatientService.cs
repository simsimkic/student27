using Model;
using SimsProjekat2020.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Service
{
    public class PatientService : IService<Patient, string>
    {
        private readonly IRepository<Patient, string> repo;
        private readonly IService<Adress, long> _addressService;
        

        public PatientService(PatientRepository repo, AddressService addressService)
        {
            this.repo = repo;
            this._addressService = addressService;
        }

        public Patient Create(Patient entity)
        {
            var address = _addressService.Create(entity.adress);
            var newPatient = repo.Create(entity);
            newPatient.adress = address;
            return newPatient;
        }

        public void Delete(Patient entity)
        {
            repo.Delete(entity);
        }

        public Patient Get(string id)
        {
            return repo.Get(id);
        }

        public IEnumerable<Patient> GetAll()
        {
            return repo.GetAll();
        }

        public void Update(Patient entity)
        {
            repo.Update(entity);
        }
    }
}
