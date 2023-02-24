using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.Interfaces
{
    interface ITermRepository : IRepository<Term, long>
    {
        IEnumerable<Term> getTermByDate(DateTime date);
        IEnumerable<Term> getTermByDoctor(Doctor doctor);
    }
}
