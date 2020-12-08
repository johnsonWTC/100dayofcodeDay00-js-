using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Models
{
    public class MemberShipType
    {
        public short id { get; set; }
        public int SignUpFee { get; set; }
        public int DurationInMonths { get; set; }
        public int DiscountInRate { get; set; }

    }
}
