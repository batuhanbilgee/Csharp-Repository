using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OrderDetailMap:BaseMap<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("dbo.OrderDetails");
            Property(x => x.VarKey).HasMaxLength(255).IsRequired();
            Property(x => x.VarValue).HasMaxLength(65535).IsRequired();
            Property(x => x.OrderId).IsOptional();
        }
    }
}
