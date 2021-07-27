using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductDetailMap:BaseMap<ProductDetail>
    {
        public ProductDetailMap()
        {
            ToTable("dbo.ProductDetails");
            Property(x => x.Sku).HasMaxLength(255).IsOptional();
            Property(x => x.Details).IsOptional();
            Property(x => x.ExtraDetails).IsOptional();
            Property(x => x.ProductId).IsOptional();
        }
    }
}
