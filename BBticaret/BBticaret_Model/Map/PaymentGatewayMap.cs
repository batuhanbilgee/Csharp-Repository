using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PaymentGatewayMap:BaseMap<PaymentGateway>
    {
        public PaymentGatewayMap()
        {
            ToTable("dbo.PaymentGateways");
            Property(x => x.Code).HasMaxLength(255).IsRequired();
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.PaymentProviderId).IsRequired();
        }
    }
}
