using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OrderItem:BaseEntity
    {
        //public OrderItem()
        //{
        //    OrderRefundRequestItems = new HashSet<OrderRefundRequestItem>();
        //    ShipmentItems = new HashSet<ShipmentItem>();
        //}
        public string ProductName { get; set; }
        public string ProductSku { get; set; }
        public string ProductBarcode { get; set; }
        public float ProductPrice { get; set; }
        public string ProductCurrency { get; set; }
        public float ProductQuantity { get; set; }
        public float ProductTax { get; set; }
        public float ProductDiscount { get; set; }
        public float ProductMoneyOrderDiscount { get; set; }
        public float ProductWeight { get; set; }
        public OrderItemProductStockTypeLabel ProductStockTypeLabel { get; set; }
        public bool IsProductPromotioned { get; set; }
        public float Discount { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("OrderItemSubscription")]
        public int OrderItemSubscriptionId { get; set; }
        public OrderItemSubscription OrderItemSubscription { get; set; }

        //public ICollection<OrderRefundRequestItem> OrderRefundRequestItems { get; set; }
        //public ICollection<ShipmentItem> ShipmentItems { get; set; }
    }
}
