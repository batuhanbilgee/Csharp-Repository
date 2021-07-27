using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShippingProviderMap:BaseMap<ShippingProvider>
    {
        public ShippingProviderMap()
        {
            ToTable("dbo.ShippingProviders");
            Property(x => x.Code).HasMaxLength(64).IsRequired();
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.TrackingUrl).HasMaxLength(1024).IsRequired();
            Property(x => x.TrackingFormMethod).IsOptional();
            Property(x => x.PayLoad).HasMaxLength(65535).IsOptional();

        }
    }
}
