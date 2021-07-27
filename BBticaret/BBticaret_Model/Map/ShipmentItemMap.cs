using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShipmentItemMap:BaseMap<ShipmentItem>
    {
        public ShipmentItemMap()
        {
            ToTable("dbo.ShipmentItems");
            Property(x => x.RootProductId).IsOptional();
            Property(x => x.Amount).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.ProductLabel).HasMaxLength(255).IsOptional();
            Property(x => x.Currency).IsRequired();
            Property(x => x.Tax).IsOptional();
            Property(x => x.Dm3).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.OrderItemId).IsRequired();
            Property(x => x.ProductId).IsOptional();
            Property(x => x.ShipmentId).IsOptional();
        }
    }
}
