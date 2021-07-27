using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductButtonMap:BaseMap<ProductButton>
    {
        public ProductButtonMap()
        {
            ToTable("dbo.ProductButtons");
            Property(x => x.FastShipping).IsOptional();
            Property(x => x.SameDayShipping).IsOptional();
            Property(x => x.ThreeDaysDelivery).IsOptional();
            Property(x => x.FiveDaysDelivery).IsOptional();
            Property(x => x.SevenDaysDelivery).IsOptional();
            Property(x => x.FreeShipping).IsOptional();
            Property(x => x.DeliveryFromStock).IsOptional();
            Property(x => x.PreOrderedProduct).IsOptional();
            Property(x => x.LimitedStock).IsOptional();
            Property(x => x.AskStock).IsOptional();
            Property(x => x.CampaignedProduct).IsOptional();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
