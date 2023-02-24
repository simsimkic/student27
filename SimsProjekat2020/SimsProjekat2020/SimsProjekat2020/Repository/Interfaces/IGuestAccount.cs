using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsProjekat2020.Repository.Interfaces
{
     public interface IGuestAccount : IRepository<GuestAccount, string>
    {
         void FromGuestAccountToRegularUser(GuestAccount guestAccount);
    }
}
