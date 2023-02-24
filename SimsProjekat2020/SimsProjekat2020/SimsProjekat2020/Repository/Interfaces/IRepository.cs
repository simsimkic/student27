using SimsProjekat2020.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository
{
    public interface IRepository <E,ID>
        where E : IIdentifiable<ID>
        where ID : IComparable
    {
        E Get(ID id);
        IEnumerable<E> GetAll();
        E Create(E entity);
        void Update(E entity);
        void Delete(E entity);
        IEnumerable<E> Find(Func<E, bool> predicate);

    }
}
