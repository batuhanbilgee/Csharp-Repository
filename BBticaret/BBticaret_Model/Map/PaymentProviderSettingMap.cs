using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PaymentProviderSettingMap:BaseMap<PaymentProviderSetting>
    {
        public PaymentProviderSettingMap()
        {
            ToTable("dbo.PaymentProviderSetting");
            Property(x => x.Varkey).HasMaxLength(255).IsRequired();
            Property(x => x.VarValue).IsRequired();
        }
    }
}
