using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductPriceMap:BaseMap<ProductPrice>
    {
        public ProductPriceMap()
        {
            ToTable("dbo.ProductPrices");
            Property(x => x.Value).IsRequired();
            Property(x => x.Type).IsRequired();
            Property(x => x.ProductId).IsRequired();

        }
    }
}
