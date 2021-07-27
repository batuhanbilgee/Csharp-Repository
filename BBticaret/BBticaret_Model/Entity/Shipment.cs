using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Shipment:BaseEntity
    {
        //public Shipment()
        //{
        //    ShipmentItems = new HashSet<ShipmentItem>();
        //}
        public string Barcode { get; set; }
        public string WaybillNo { get; set; }
        public string InvoiceKey { get; set; }
        public string CargoOffice { get; set; }
        public string Code { get; set; }
        public string DeliveryType { get; set; }
        public bool InvoiceIncluded { get; set; }
        public float PayAtDoorAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string BarcodeImage { get; set; }
        public string TrackingUrl { get; set; }

        //public ICollection<ShipmentItem> ShipmentItems { get; set; }

    }
}
