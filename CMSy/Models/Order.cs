using CMSy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMSy.Models
{
    public class Order
    {    
        //orders -> id, table_number
        private int table_id;
        private int order_id;
        public int TableId
        {
            get { return table_id; }
            set { table_id = value; }
        }

        public int OrderId
        {
            get { return order_id; }
            set { order_id = value; }
        }

        public Order(int table_id, int order_id)
        {
            TableId = table_id;
            OrderId = order_id;
        }
    }
}