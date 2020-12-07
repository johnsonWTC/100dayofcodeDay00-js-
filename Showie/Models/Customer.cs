using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Showie.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool isSubsribedToNewsLetter { get; set; }

        public MemberShipType MemberShipType { get; set; }

        public short MemberShipTypeId { get; set; }
    }
}
