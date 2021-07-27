using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class SelectionMap:BaseMap<Selection>
    {
        public SelectionMap()
        {
            ToTable("dbo.Selections");
            Property(x => x.Title).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsRequired();
            Property(x => x.SelectionGroupId).IsOptional();
        }
    }
}
