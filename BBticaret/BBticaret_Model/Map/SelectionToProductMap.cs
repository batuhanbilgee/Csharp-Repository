using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class SelectionToProductMap:BaseMap<SelectionToProduct>
    {
        public SelectionToProductMap()
        {
            ToTable("dbo.SelectionToProducts");
            Property(x => x.SelectionId).IsRequired();
            Property(x => x.ProductId).IsRequired();
        }
    }
}
