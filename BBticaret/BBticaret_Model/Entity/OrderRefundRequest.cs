using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OrderRefundRequest:BaseEntity
    {
        //public OrderRefundRequest()
        //{
        //    OrderRefundRequestItems = new HashSet<OrderRefundRequestItem>();
        //}
        public string Code { get; set; }
        public OrderRefundRequestStatus Status { get; set; }
        public float Fee { get; set; }
        public string CancellationReason { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        //public ICollection<OrderRefundRequestItem> OrderRefundRequestItems { get; set; }
    }
}
