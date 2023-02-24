using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV
{
    public interface ICSVConverter<E> 
        where E : class
    {
        string ConvertToCSV(E entity);
        E ConvertToEntity(string entityCSVformat);

    }
}
