using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Controller
{
    public interface IController<E, ID> where E : class
    {
        IEnumerable<E> GetAll();
        E Get(ID id);
        E Create(E entity);
        void Update(E entity);
        void Delete(E entity);
    }
}
