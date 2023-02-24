using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.CSV
{
    class DepartmentConverter : ICSVConverter<Department>
    {
        private readonly string delimiter;

        public DepartmentConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }
        public string ConvertToCSV(Department department)
        {
            return string.Join(delimiter,
                department.DepartmentName,
                department.Doctor
               ) ;
        }

       
        public Department ConvertToEntity(string CSVformat)
        {
            throw new NotImplementedException();
        }
    }
}
