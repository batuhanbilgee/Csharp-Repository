using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class CombineProductMap:BaseMap<CombineProduct>
    {
        public CombineProductMap()
        {
            ToTable("dbo.CombineProducts");
            Property(x => x.CombineProductId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
