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
    public class GuestAccountRepository : CSVRepository<GuestAccount, string>,
         IGuestAccount,
         IEagerCSVRepository<GuestAccount, string>
    {
        private UserRepository _userRepository;
        private const string ENTITY_NAME = "GuestAccount";
        private const string NOT_UNIQUE_ERROR = "GuestAccount number {0} is not unique!";
        public GuestAccountRepository(ICSVStream<GuestAccount> stream, ISequencer<string> sequencer)
           : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public void FromGuestAccountToRegularUser(GuestAccount guestAccount)
        {
            _userRepository.Create(guestAccount);
            Delete(guestAccount);
        }

        public IEnumerable<GuestAccount> GetAllEager() => GetAll();

        public GuestAccount GetEager(string id) => Get(id);
       
    }
}
