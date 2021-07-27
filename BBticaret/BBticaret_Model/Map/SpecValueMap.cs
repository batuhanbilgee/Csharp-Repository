using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class SpecValueMap:BaseMap<SpecValue>
    {
        public SpecValueMap()
        {
            ToTable("dbo.SpecValues");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.Logo).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.Attachment).IsOptional();
            Property(x => x.SpecGroupId).IsOptional();
            Property(x => x.SpecNameId).IsOptional();
            Property(x => x.UpdatedAt).IsOptional();
            Property(x => x.CreatedAt).IsOptional();
        }
    }
}
