using Model;
using SimsProjekat2020.Repository.CSV;
using SimsProjekat2020.Repository.CSV.FileStream;
using SimsProjekat2020.Repository.Sequncer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository
{
    public class TermRepository : CSVRepository<Term, long>
    {
        private string name;
        private ICSVStream<Term> stream;
        private ISequencer<long> sequencer;
        public TermRepository(string entityName, ICSVStream<Term> stream, ISequencer<long> sequencer) : base(entityName, stream, sequencer)
        {
            this.name = entityName;
            this.stream = stream;
            this.sequencer = sequencer;
        }
    }
}
