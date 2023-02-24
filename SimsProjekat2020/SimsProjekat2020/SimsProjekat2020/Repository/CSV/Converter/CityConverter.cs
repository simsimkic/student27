using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.Converter
{
    public class CityConverter : ICSVConverter<City>
    {
        private readonly string delimiter;
        

        public CityConverter(string delimiter)
        {
            this.delimiter = delimiter;
            
        }

        public string ConvertToCSV(City city)
        {
            return string.Join(delimiter,
                city.Id,
                city.PostCode,
                city.Name,
                city.State.Name);
        }

        public City ConvertToEntity(string entityCSVformat)
        {
            string[] tokens = entityCSVformat.Split(delimiter.ToCharArray());
            State state = new State(tokens[3]);
            City c =  new City(tokens[0],int.Parse(tokens[1]), tokens[2], state);
            return c;
        }
    }
}
