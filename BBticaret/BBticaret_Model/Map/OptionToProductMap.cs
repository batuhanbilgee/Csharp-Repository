using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OptionToProductMap:BaseMap<OptionToProduct>
    {
        public OptionToProductMap()
        {
            ToTable("dbo.OptionToProducts");
            Property(x => x.ParentProductId).IsRequired();
            Property(x => x.OptionGroupId).IsRequired();
            Property(x => x.OptionId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
