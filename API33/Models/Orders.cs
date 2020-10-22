using System;
using System.Collections;
using System.Collections.Generic;

namespace API33.Models
{
    public class Orders
    {

        public int id { get; set; }
        public DateTime orderPlaced { get; set; }
        public DateTime ? orderFullFilled { get; set; }

        public int customerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<ProductOrder> ProductOrder { get; set; }
    }
}