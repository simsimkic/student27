using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimsProjekat2020.Repository.CSV
{
    class BlogConverter : ICSVConverter<Blog>
    {
        private readonly string dateTimeFormat;
        private readonly string delimiter;
        public string ConvertToCSV(Blog blog)
        {
            return string.Join(delimiter,
               blog.Text,
               blog.Title,
               blog.Category,
               blog.RealiseDate.ToString(dateTimeFormat),
               blog.Author.employeeId);
        }

        public Blog ConvertToEntity(string CSVformat)
        {
            string[] tokens = CSVformat.Split(delimiter.ToCharArray());

            return new Blog (tokens[0],
                tokens[1],
                tokens[2],
                DateTime.Parse(tokens[3]),
                null);
        }
    }
}
