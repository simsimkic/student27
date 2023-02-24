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
    public class AddressRepository : CSVRepository<Adress, long>,
        IAddressRepository
    {
        private const string ENTITY_NAME = "Address";
        public AddressRepository(ICSVStream<Adress> stream, ISequencer<long> sequencer) : base(ENTITY_NAME, stream, sequencer)
        {
        }
    }
}
