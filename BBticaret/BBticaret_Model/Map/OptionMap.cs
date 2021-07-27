
using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class OptionMap:BaseMap<Option>
    {
        public OptionMap()
        {
            ToTable("dbo.Options");
            Property(x => x.Title).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).IsOptional();
            Property(x => x.SortOrder).IsRequired();
            Property(x => x.Logo).IsOptional();
            Property(x => x.OptionGroupId).IsOptional();
            Property(x => x.Attachment).IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();



        }
    }
}
