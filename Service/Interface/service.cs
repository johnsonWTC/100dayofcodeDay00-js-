using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Interface
{
    interface service
    {
      IEnumerable<User> getallUser();
        User GetUserById(int id);
        User GetUserById();
    }
}
