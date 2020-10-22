using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API32.Models
{

    // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
    public class Customer
    {
#nullable  enable
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ? Address { get; set; }

        public string ? Phone { get; set; }

#nullable disable
        public ICollection<Orders> Orders { get; set; }

    }
}
