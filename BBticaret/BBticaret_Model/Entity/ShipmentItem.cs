using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ShipmentItem:BaseEntity
    {
        public float RootProductId { get; set; }
        public float Amount { get; set; }
        public float Price { get; set; }
        public string ProductLabel { get; set; }
        public ShipmentItemCurrency Currency { get; set; }
        public float Tax { get; set; }
        public float Dm3 { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        public DateTime UpdatedAt { get; set; }
        [ForeignKey("OrderItem")]
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Shipment")]
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; }

    }
}
