using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OrderItemSubscriptionMap:BaseMap<OrderItemSubscription>
    {
        public OrderItemSubscriptionMap()
        {
            ToTable("dbo.OrderItemSubscriptions");
            Property(x => x.OrderItemCustomizationId).IsOptional();
        }
    }
}
