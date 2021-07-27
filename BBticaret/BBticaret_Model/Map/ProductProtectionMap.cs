using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ProductProtectionMap:BaseMap<ProductProtection>
    {
        public ProductProtectionMap()
        {
            ToTable("dbo.ProductProtections");
            Property(x => x.IsPriceProtected).IsRequired();
            Property(x => x.IsStockProtected).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
