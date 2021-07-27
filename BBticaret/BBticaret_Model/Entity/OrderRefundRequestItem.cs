using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OrderRefundRequestItem:BaseEntity
    {
        public float Amount { get; set; }
        public OrderRefundRequestItemReason Reason { get; set; }
        public string Details { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("OrderItem")]
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        [ForeignKey("OrderRefundRequest")]
        public int OrderRefundRequestId { get; set; }
        public OrderRefundRequest OrderRefundRequest { get; set; }
    }
}
