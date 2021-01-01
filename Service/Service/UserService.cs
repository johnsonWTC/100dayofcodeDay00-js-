using Service.Data;
using Service.Interface;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserService : UserI
    {
        private readonly Context context;
        public UserService(Context _context)
        {
            context = _context;
        }
        public IEnumerable<User> getallUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
