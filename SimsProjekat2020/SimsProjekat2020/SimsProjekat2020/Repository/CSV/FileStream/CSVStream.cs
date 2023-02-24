using SimsProjekat2020.Repository.CSV.Converter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.FileStream
{
    public class CSVStream<E> : ICSVStream<E>
        where E : class
    {
        private readonly string _path;
        private readonly ICSVConverter<E> _converter;
     

        public CSVStream(string path, ICSVConverter<E> converter)
        {
            _path = path;
            _converter = converter;
        }
                

        public void AppendToFile(E entity)
            => File.AppendAllText(_path,
                _converter.ConvertToCSV(entity) + Environment.NewLine);

        public IEnumerable<E> ReadAll()
            => File.ReadAllLines(_path)
                   .Select(_converter.ConvertToEntity)
                   .ToList();

        public void SaveAll(IEnumerable<E> entities)
            => WriteAllLinesToFile(entities.Select(_converter.ConvertToCSV)
                                           .ToList());
        public void WriteAllLinesToFile(IEnumerable<string> content)
            => File.WriteAllLines(_path, content.ToArray());
    }
}
