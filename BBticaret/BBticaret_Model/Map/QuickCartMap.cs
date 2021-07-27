using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class QuickCartMap:BaseMap<QuickCart>
    {
        public QuickCartMap()
        {
            ToTable("dbo.QuickCarts");
            Property(x => x.Name) .HasMaxLength(255).IsRequired();
            Property(x => x.Url).HasMaxLength(2048).IsRequired();
            Property(x => x.ShortUrl).HasMaxLength(255).IsOptional();
            Property(x => x.CartId).IsOptional();
        }
    }
}
