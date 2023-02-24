using Model;
using SimsProjekat2020.Repository.CSV;
using SimsProjekat2020.Repository.CSV.FileStream;
using SimsProjekat2020.Repository.Interfaces;
using SimsProjekat2020.Repository.Sequncer;

namespace SimsProjekat2020.Repository
{
    public class StateRepository : CSVRepository<State, string>,
        IStateRepository
      {
        private const string ENTITY_NAME = "State";
      
        public StateRepository(ICSVStream<State> stream, ISequencer<string> sequencer) : base(ENTITY_NAME, stream,sequencer)
        {
        }
       
    }
}
