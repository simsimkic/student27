using Model;
using SimsProjekat2020.Repository.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.CSV
{
    class TermConverter : ICSVConverter<Term>
    {
        public string ConvertToCSV(Term entity)
        {
			List<Term> ts = new List<Term>();
			var tt = ts.Where(t => t.Doctor.employeeId == 123).ToList();
            throw new NotImplementedException();
        }

        public Term ConvertToEntity(string CSVformat)
        {
            throw new NotImplementedException();
        }
    }
}
