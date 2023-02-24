using Model;
using SimsProjekat2020.Repository.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV
{
    class EmployeeCSVConverter : ICSVConverter<Employee>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public EmployeeCSVConverter(string _delimiter, string _datetimeFormat)
        {
            this._delimiter = _delimiter;
            this._datetimeFormat = _datetimeFormat;
        }

        public Employee ConvertToEntity(string employeeCSVformat)
        {
            string[] tokens = employeeCSVformat.Split(_delimiter.ToCharArray());
            return null;
           
        }
        public string ConvertToCSV(Employee entity)
        {
            throw new NotImplementedException();
        }

        /*public string ConvertEntityToCSVFormat(Employee employee)
            => string.Join(_delimiter,
                employee.ID)
    
    */
    }
}
