using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OptionGroupMap:BaseMap<OptionGroup>
    {
        public OptionGroupMap()
        {
            ToTable("dbo.OptionGroups");
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.FilterStatus).IsOptional();

        }
    }
}
