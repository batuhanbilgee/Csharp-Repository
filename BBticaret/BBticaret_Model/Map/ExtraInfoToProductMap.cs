using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ExtraInfoToProductMap:BaseMap<ExtraInfoToProduct>
    {
        public ExtraInfoToProductMap()
        {
            ToTable("dbo.ExtraInfoToProducts");
            Property(x => x.Value).HasMaxLength(65535).IsRequired();
            Property(x => x.ExtraInfoId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
