using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductToCountDownMap:BaseMap<ProductToCountDown>
    {
        public ProductToCountDownMap()
        {
            ToTable("dbo.ProductToCountDowns");
            Property(x => x.StartDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.EndDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.ExpireDate).HasColumnType("datetime2").IsOptional();
            Property(x => x.UseCountDown).IsRequired();
            Property(x => x.ProductId).IsOptional();
        }
    }
}
