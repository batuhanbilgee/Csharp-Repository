using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OrderItemSubscription:BaseEntity
    {
        //public OrderItemSubscription()
        //{
        //    OrderItems = new HashSet<OrderItem>();
        //}
        //public ICollection<OrderItem> OrderItems { get; set; }
        public int OrderItemCustomizationId { get; set; }
        public OrderItemCustomization OrderItemCustomization { get; set; }
    }
}
