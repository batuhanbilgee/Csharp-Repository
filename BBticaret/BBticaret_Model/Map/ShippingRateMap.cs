using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShippingRateMap:BaseMap<ShippingRate>
    {
        public ShippingRateMap()
        {
            ToTable("dbo.ShippingRates");
            Property(x => x.VolumetricWeightStart).IsRequired();
            Property(x => x.VolumetricWeightEnd).IsRequired();
            Property(x => x.Rate).IsRequired();
            Property(x => x.RegionId).IsOptional();
            Property(x => x.ShippingCompanyId).IsOptional();
        }
    }
}
