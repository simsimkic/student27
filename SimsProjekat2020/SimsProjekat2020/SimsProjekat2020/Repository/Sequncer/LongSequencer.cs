using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.Sequncer
{
    public class LongSequencer : ISequencer<long>
    {
        private long _nextId;

        public long GenerateId() { return _nextId++; }

        public void Initialize(long initId) => _nextId = initId;
    }
}
