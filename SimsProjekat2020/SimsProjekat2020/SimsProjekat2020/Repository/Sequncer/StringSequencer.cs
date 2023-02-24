using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.Sequncer
{
   public class StringSequencer : ISequencer<string>
    {
        private string _nextString;

       public string GenerateId()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];
            
            _nextString = new String(stringChars);
            return _nextString;
        }

        public void Initialize(string initId) => _nextString = initId;
    }
}
