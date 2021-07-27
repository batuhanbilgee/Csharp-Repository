using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class SpecToProductMap:BaseMap<SpecToProduct>
    {
        public SpecToProductMap()
        {
            ToTable("dbo.SpecToProducts");
            Property(x => x.ProductId).IsOptional();
            Property(x => x.SpecGroupId).IsOptional();
            Property(x => x.SpecNameId).IsOptional();
            Property(x => x.SpecValueId).IsOptional();
        }
    }
}
