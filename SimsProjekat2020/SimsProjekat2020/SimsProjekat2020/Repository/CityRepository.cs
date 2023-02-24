using Model;
using SimsProjekat2020.Repository.CSV;
using SimsProjekat2020.Repository.CSV.FileStream;
using SimsProjekat2020.Repository.Interfaces;
using SimsProjekat2020.Repository.Sequncer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository
{
    public class CityRepository : CSVRepository<City, string>,
        ICityRepository
    {
        private const string ENTITY_NAME = "City";
        public CityRepository(ICSVStream<City> stream, ISequencer<string> sequencer) : base(ENTITY_NAME, stream, sequencer)
        {
        }
    }
}
