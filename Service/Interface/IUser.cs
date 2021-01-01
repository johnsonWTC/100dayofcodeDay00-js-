using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IUser
    {
      IEnumerable<User> getallUser();
        User GetUserById(int id);
       
    }
}
