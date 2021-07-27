using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class LabelMap:BaseMap<Label>
    {
        public LabelMap()
        {
            ToTable("dbo.Labels");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.HasChildren).IsOptional();
            Property(x => x.Slug).HasMaxLength(255).IsOptional();
            Property(x => x.MetaTitle).HasMaxLength(255).IsOptional();
            Property(x => x.MetaKeywords).HasMaxLength(255).IsOptional();
            Property(x => x.MetaDescription).HasMaxLength(255).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.LabelId).IsOptional();
            Property(x => x.CreatedAt).IsRequired();
            Property(x => x.UpdatedAt).IsRequired();






        }
    }
}
