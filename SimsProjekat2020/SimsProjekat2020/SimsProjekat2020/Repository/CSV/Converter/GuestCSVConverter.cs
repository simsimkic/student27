using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.CSV.Converter
{
    public class GuestCSVConverter : ICSVConverter<GuestAccount>
    {
        private readonly string _delimiter;

        public GuestCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertToCSV(GuestAccount guestAcc)
            => string.Join(_delimiter,
                guestAcc.firstName,
                guestAcc.lastName,
                guestAcc.personalId,
                guestAcc.dateOfBirth,
                guestAcc.phoneNumber,
                guestAcc.email,
                guestAcc.gender,
                guestAcc.username = null,
                guestAcc.password = null,
                guestAcc.adress,
                guestAcc.isGuest);
            
        public GuestAccount ConvertToEntity(string entityCSVformat)
        {
            string[] tokens = entityCSVformat.Split(_delimiter.ToCharArray());
            return new GuestAccount(
                tokens[0],
                tokens[1],
                tokens[2],
                Convert.ToDateTime(tokens[3]),
                tokens[4],
                tokens[5],
                getGender(tokens[6]),
                tokens[7],
                tokens[8],
                new Adress(tokens[9]),
                true);
        }

        private Gender getGender(string gender)
        {
            if (gender.Equals("male"))
                return Gender.male;
            else
                return Gender.female;
        }
    }
}
