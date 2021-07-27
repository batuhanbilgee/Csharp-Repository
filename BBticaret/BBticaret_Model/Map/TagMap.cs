using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class TagMap:BaseMap<Tag>
    {
        public TagMap()
        {
            ToTable("dbo.Tag");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Count).IsOptional();
            Property(x => x.PageTitle).HasMaxLength(65535).IsOptional();
            Property(x => x.MetaDescription).HasMaxLength(65535).IsOptional();
            Property(x => x.MetaKeywords).HasMaxLength(65535).IsOptional();


        }

    }
}
