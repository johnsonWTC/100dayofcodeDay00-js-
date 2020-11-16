using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class IdentityContext : IdentityDbContext<User,AppRole,int>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }

    }
}
