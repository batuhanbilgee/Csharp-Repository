using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShopTokenMap:BaseMap<ShopToken>
    {
        public ShopTokenMap()
        {
            ToTable("dbo.ShopTokens");
            Property(x => x.Code)
                .HasMaxLength(255)
                .IsOptional();
        }
    }
}
