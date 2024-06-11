using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2024
{
    public class Order
    {
        public int UserId { get; set; }
        public List<OrderItem> Items { get; set; }
        public DateTime OrderDate { get; set; }

        public class OrderItem
        {
            public int ProductId { get; set; }
            public int Quantity { get; set; }
        }
    }
}
