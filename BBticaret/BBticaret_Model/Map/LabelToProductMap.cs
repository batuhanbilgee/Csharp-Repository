using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class LabelToProductMap:BaseMap<LabelToProduct>
    {
        public LabelToProductMap()
        {
            ToTable("dbo.LabelToProducts");
            Property(x => x.LabelId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
