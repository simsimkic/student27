using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.Interfaces
{
    public interface IIdentifiable<T>
    {
        T GetId();
        void SetId(T id);
    }
}
