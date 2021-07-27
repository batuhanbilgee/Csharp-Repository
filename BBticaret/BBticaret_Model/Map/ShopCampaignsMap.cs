using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShopCampaignsMap:BaseMap<ShopCampaigns>
    {
        public ShopCampaignsMap()
        {
            ToTable("dbo.ShopCampaigns");
            Property(x => x.Label).HasMaxLength(255).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
        }
    }
}
