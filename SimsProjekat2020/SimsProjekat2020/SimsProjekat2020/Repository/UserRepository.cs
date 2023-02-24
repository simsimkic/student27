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
    public class UserRepository : CSVRepository<User, string>,
        IUserRepository,
        IEagerCSVRepository<User, string>
    {
        private const string ENTITY_NAME = "User";
        private const string NOT_UNIQUE_ERROR = "User number {0} is not unique!";
               
        public UserRepository(ICSVStream<User> stream, ISequencer<string> sequencer)
           : base(ENTITY_NAME, stream, sequencer)
        {

        }



        public IEnumerable<User> GetAllEager() => GetAll();

        public new User Create(User user)
        {
            if (IsPersonaIDUnique(user.personalId))
            {
                Console.WriteLine("USAO u create: " + user.personalId);
                _stream.AppendToFile(user);
                return user;
            }
            else
            {
                Console.WriteLine("THrow " + user.personalId);
                throw new NotUniqueException(string.Format(NOT_UNIQUE_ERROR, user.personalId));
            }
        }

        private bool IsPersonaIDUnique(string personalId)
            => GetUserByPersonalID(personalId) == null;

        private User GetUserByPersonalID(string personalId)
            => _stream.ReadAll().SingleOrDefault(user => user.personalId.Equals(personalId));
       

        public User GetEager(string id) => Get(id);
       public void Login(string username, string password)
        {
           /* foreach (User u in _userRepository.GetAllEager()) { 
                
            }*/
        }
    }
}
