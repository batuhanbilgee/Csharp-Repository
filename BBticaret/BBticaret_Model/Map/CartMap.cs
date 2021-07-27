using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class CartMap:BaseMap<Cart>
    {
        public CartMap()
        {
            ToTable("dbo.Carts");
            Property(x => x.SessionId).HasMaxLength(255).IsRequired();
            Property(x => x.Locked).IsRequired();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.ShopCampaingsId).IsOptional();
            Property(x => x.MemberId).IsOptional();
            Property(x => x.ShopTokenId).IsOptional();


        }
    }
}
