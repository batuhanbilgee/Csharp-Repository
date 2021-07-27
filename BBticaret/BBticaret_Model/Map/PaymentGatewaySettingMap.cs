using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PaymentGatewaySettingMap:BaseMap<PaymentGatewaySetting>
    {
        public PaymentGatewaySettingMap()
        {
            ToTable("dbo.PaymentGatewaySettings");
            Property(x => x.Varkey).HasMaxLength(255).IsRequired();
            Property(x => x.VarValue).HasMaxLength(255).IsRequired();
            Property(x => x.PaymentGatewayId).IsOptional();

        }
    }
}
