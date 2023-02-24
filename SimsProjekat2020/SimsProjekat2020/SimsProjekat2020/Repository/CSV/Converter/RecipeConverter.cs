using Model;
using SimsProjekat2020.Repository.CSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.CSV
{
    class RecipeConverter:ICSVConverter<Recipe>
    {
        private readonly string dateTimeFormat;
        private readonly string delimiter;

        public RecipeConverter(string delimiter, string dateTimeFormat)
        {
            this.delimiter = delimiter;
            this.dateTimeFormat = dateTimeFormat;
        }
        public string ConvertToCSV(Recipe entity)
        {
            return string.Join(delimiter,
                entity.doctor,
                entity.medicine);
        }

        public Recipe ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());

            return new Recipe(new Medicine(), null);
        }
    }
}
