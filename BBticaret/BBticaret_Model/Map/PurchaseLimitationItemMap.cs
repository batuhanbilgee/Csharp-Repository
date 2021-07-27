using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PurchaseLimitationItemMap:BaseMap<PurchaseLimitationItem>
    {
        public PurchaseLimitationItemMap()
        {
            ToTable("dbo.PurchaseLimitationItems");
            Property(x => x.BrandId).IsOptional();
            Property(x => x.CategoryId).IsOptional();
            Property(x => x.LimitationId).IsOptional();
            Property(x => x.MemberGroupId).IsOptional();
            Property(x => x.ProductId).IsOptional();
        }
    }
}
