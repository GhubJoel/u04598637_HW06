using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u04598637_HW06.Models
{
    public class orderslist
    {
        public System.DateTime order_date { get; set; }
        public int order_id { get; set; }
        public int item_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int quantity { get; set; }
        public decimal list_price { get; set; }
    }
}