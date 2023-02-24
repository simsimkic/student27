using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.Interfaces
{
    interface IEmployeeRepository //: IRepository<Employee, long>
    {
        Doctor GetDoctorByDepartment(Department department);
    }
}
