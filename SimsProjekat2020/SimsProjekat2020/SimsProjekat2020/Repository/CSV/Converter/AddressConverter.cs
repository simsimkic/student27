using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.Converter
{
    public class AddressConverter : ICSVConverter<Adress>
    {
        private readonly string delimiter;
        
        public AddressConverter(string del) {
            delimiter = del;
            
        }
        public string ConvertToCSV(Adress address)
        {
            return string.Join(delimiter,
                address.Id,
                address.street,
                address.city.Name);
        }

        public Adress ConvertToEntity(string CSVFormat)
        {
            string[] tokens = CSVFormat.Split(delimiter.ToCharArray());
            Adress address = new Adress(long.Parse(tokens[0]), tokens[1], new City(tokens[2]));
            return address;

        }
    }
}
