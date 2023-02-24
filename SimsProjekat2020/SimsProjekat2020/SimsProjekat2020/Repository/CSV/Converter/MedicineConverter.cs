using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.Converter
{
    public class MedicineConverter : ICSVConverter<Medicine>
    {
        private readonly string delimiter;
        public MedicineConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }
        public string ConvertToCSV(Medicine medicine)
        {

            return string.Join(delimiter,
                medicine.MedicineId,
                medicine.Name,
                medicine.Ingredients,
                medicine.Description,
                medicine.TypeOfUse,
                medicine.Amount,
                medicine.Approved
                );
        }

        public Medicine ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());
            return new Medicine(
                tokens[0],
                tokens[1],
                new List<string>(),
                tokens[3], 
                tokens[4],
                int.Parse(tokens[5]),
                bool.Parse(tokens[6])
                );
        }
    }
}
