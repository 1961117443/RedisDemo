using System;
using System.Collections.Generic;
using System.Text;

namespace EntityModel
{
    public class Order
    {
        public string OrderNo { get; set; }
        public string OrderDate { get; set; }

        public override string ToString()
        {
            return this.OrderNo;
        }
    }
}
