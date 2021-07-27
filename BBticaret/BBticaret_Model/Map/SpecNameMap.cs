using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class SpecNameMap:BaseMap<SpecName>
    {
        public SpecNameMap()
        {
            ToTable("dbo.SpecName");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).HasMaxLength(255).IsRequired();
            Property(x => x.ChoiceType).IsRequired();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.SpecGroupId).IsRequired();
        }
    }
}
