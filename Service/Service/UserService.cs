using Service.Data;
using Service.Interface;
using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserService : IUser
    {
        private readonly Context context;
        public UserService(Context _context)
        {
            context = _context;
        }
        public IEnumerable<User> getallUser()
        {
            return context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return context.Users.FirstOrDefault(e => e.UserId == id);
        }
    }
}
