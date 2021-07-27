using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OrderRefundRequestItemMap:BaseMap<OrderRefundRequestItem>
    {
        public OrderRefundRequestItemMap()
        {
            ToTable("dbo.OrderRefundRequestItems");
            Property(x => x.Amount).IsRequired();
            Property(x => x.Reason).IsRequired();
            Property(x => x.Details).HasMaxLength(65535).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.OrderItemId).IsRequired();
            Property(x => x.OrderRefundRequestId).IsRequired();

        }
    }
}
