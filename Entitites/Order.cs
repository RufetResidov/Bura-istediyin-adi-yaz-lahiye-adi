using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order : BaseEntity
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAdress { get; set; }
        public string OrderCode { get; set; }
        public int PaymentMethod { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal DeliveryChanges { get; set; }
        public DateTime PlacedOn { get; set; }
        public decimal TransactionID { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<OrderHistory> OrderHistory { get; set; }
    }
}
