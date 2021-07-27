using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class InstallmentRateMap:BaseMap<InstallmentRate>
    {
        public InstallmentRateMap()
        {
            ToTable("dbo.InstallmentRates");
            Property(x => x.Installment).IsRequired();
            Property(x => x.Rate).IsRequired();
            Property(x => x.PaymentGatewayId).IsRequired();
        }
    }
}
