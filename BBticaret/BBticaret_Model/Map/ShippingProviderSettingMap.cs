using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShippingProviderSettingMap:BaseMap<ShippingProviderSetting>
    {
        public ShippingProviderSettingMap()
        {
            ToTable("dbo.ShippingProviderSettings");
            Property(x => x.VarKey).HasMaxLength(255).IsRequired();
            Property(x => x.VarValue).HasMaxLength(65535).IsRequired();
            Property(x => x.ShippingProviderId).IsOptional();

        }
    }
}
