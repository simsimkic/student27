using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimsProjekat2020.Model.Util
{
    class JmbgNumber
    {
        private readonly Regex _regex = new Regex(@"[0-9]{13}");
        private const string ERROR_MESSAGE = "Invalid jmbg number. Must enter 13 digits.";

        private string _value;

        public JmbgNumber(string jmbgNumber)
        {
            if (IsValidFormat(jmbgNumber))
                _value = jmbgNumber;
            else { }
               // ThrowException();

        }
       /* public string Jmbg
        {
            get => _value;
            set{
                if (IsValidFormat(value))
                    _value = value;
                else { }
            }

        }*/
        private bool IsValidFormat(string jmbgNumber)
            => _regex.Match(jmbgNumber).Success;

       /* private void ThrowException()
            => ThrowException new ValidationException(ERROR_MESSAGE);*/
    }
}
