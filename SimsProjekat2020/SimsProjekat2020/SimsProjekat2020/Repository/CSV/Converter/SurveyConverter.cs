using Model;
using SimsProjekat2020.Repository.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace SimsProjekat2020.Repository.CSV
{
    class SurveyConverter : ICSVConverter<Survey>
    {
        private readonly string delimiter;

        public SurveyConverter(string delimiter)
        {
            this.delimiter = delimiter;
            
        }
        public string ConvertToCSV(Survey entity)
        {
            return string.Join(delimiter,
                  entity.questions,
                  entity.answer,
                  entity.comment,
                  entity.patient,
                  entity.doctor);
        }

        public Survey ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());

            return new Survey(tokens[0], Int32.Parse(tokens[1]), tokens[2], null, null);
        }
    }
}
