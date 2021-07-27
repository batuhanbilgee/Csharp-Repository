using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PaymentProviderMap:BaseMap<PaymentProvider>
    {
        public PaymentProviderMap()
        {
            ToTable("dbo.PaymentProviders");
            Property(x => x.Code).HasMaxLength(255).IsRequired();
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.PaymentTypeId).IsOptional();
            Property(x => x.PaymentProviderSettingId).IsOptional();
        }
    }
}
