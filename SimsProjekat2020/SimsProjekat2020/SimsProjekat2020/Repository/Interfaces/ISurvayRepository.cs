using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.Interfaces
{
    interface ISurvayRepository :IRepository<Survey, long>
    {
        IEnumerable<Survey> GetSurveysByDoctor(Doctor doctor);

    }
}
