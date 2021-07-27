using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShipmentMap:BaseMap<Shipment>
    {
        public ShipmentMap()
        {
            ToTable("dbo.Shipments");
            Property(x => x.Barcode).HasMaxLength(255).IsOptional();
            Property(x => x.WaybillNo).HasMaxLength(255).IsOptional();
            Property(x => x.InvoiceKey).HasMaxLength(255).IsOptional();
            Property(x => x.CargoOffice).HasMaxLength(255).IsOptional();
            Property(x => x.Code).HasMaxLength(255).IsOptional();
            Property(x => x.DeliveryType).HasMaxLength(255).IsOptional();
            Property(x => x.InvoiceIncluded).IsOptional();
            Property(x => x.PayAtDoorAmount).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.OrderId).IsRequired();
            Property(x => x.BarcodeImage).HasMaxLength(16777215).IsOptional();
            Property(x => x.TrackingUrl).HasMaxLength(255).IsOptional();
        }
    }
}
