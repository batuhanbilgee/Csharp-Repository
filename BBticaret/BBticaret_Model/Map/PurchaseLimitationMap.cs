using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PurchaseLimitationMap:BaseMap<PurchaseLimitation>
    {
        public PurchaseLimitationMap()
        {
            ToTable("dbo.PurchaseLimitation");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.MinimumLimit).IsOptional();
            Property(x => x.MaximumLimit).IsOptional();
            Property(x => x.Type).IsRequired();
            Property(x => x.Status).IsOptional();
        }
    }
}
