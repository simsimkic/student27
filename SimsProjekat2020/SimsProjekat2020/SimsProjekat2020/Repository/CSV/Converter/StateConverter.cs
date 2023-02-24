using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.Converter
{
    public class StateConverter : ICSVConverter<State>
    {
        private readonly string delimiter;

        public StateConverter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string ConvertToCSV(State entity)
        {
            return string.Join(delimiter,
                entity.Id,
                entity.Name);
        }

        public State ConvertToEntity(string entityCSVformat)
        {
            string[] tokens = entityCSVformat.Split(delimiter.ToCharArray());

            return new State(tokens[0], tokens[1]);
        }
    }
}
