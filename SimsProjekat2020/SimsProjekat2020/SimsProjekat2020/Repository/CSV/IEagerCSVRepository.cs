using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV
{
    public interface IEagerCSVRepository<E,ID>
        where E : IIdentifiable<ID>
        where ID : IComparable
    {
        E GetEager(ID id);
        IEnumerable<E> GetAllEager();
    }
}
