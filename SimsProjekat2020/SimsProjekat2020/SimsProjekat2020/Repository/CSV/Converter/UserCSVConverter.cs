using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV
{
   public class UserCSVConverter : ICSVConverter<User>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;
        public UserCSVConverter(string delimiter, string dateFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = dateFormat;
        }
        public User ConvertToEntity(string userCSVformat)
        {
            Gender pol;

            string[] tokens = userCSVformat.Split(_delimiter.ToCharArray());
            if (tokens[6].Equals("male"))
            {
                pol = Gender.male;
            }
            else {
                pol = Gender.female;
            }

            return new User(
                tokens[0],
                tokens[1],
                tokens[2],
                DateTime.Parse(tokens[3]),
                tokens[4],
                tokens[5],
                tokens[7],
                tokens[8],
                new Adress(tokens[9]));
        }

        public string ConvertToCSV(User user)
            => string.Join(_delimiter,
                user.firstName,
                user.lastName,
                user.personalId,
                user.dateOfBirth.ToString(_datetimeFormat),
                user.phoneNumber,
                user.email,
                user.gender,
                user.username,
                user.password,
                user.adress);
    }
}
