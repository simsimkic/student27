using Model;
using SimsProjekat2020.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public class PatientController : IController<Patient, string>
    {
        private PatientService patientService;

        public PatientController(PatientService patientService)
        {
            this.patientService = patientService;
        }

        public Patient Create(Patient entity)
        {
            return patientService.Create(entity);   
        }

        public void Delete(Patient entity)
        {
            patientService.Delete(entity);
        }

        public Patient Get(string id)
        {
            return patientService.Get(id);
        }

        public IEnumerable<Patient> GetAll()
        {
            return patientService.GetAll();
        }

        public void Update(Patient entity)
        {
            patientService.Update(entity);
        }
    }
}
