using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.FileStream
{
    public interface ICSVStream<E>
    {
        void SaveAll(IEnumerable<E> entities);
        IEnumerable<E> ReadAll();
        void AppendToFile(E entity);
        
    }
}
