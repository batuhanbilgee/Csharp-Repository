using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class BrandMap:BaseMap<Brand>
    {
        public BrandMap()
        {
            ToTable("dbo.Brands");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsRequired();
            Property(x => x.Status).IsRequired();
            Property(x => x.DistributorCode).HasMaxLength(255).IsOptional();
            Property(x => x.Distributor).HasMaxLength(255).IsOptional();
            Property(x => x.ImageFile).HasMaxLength(255).IsOptional();
            Property(x => x.ShowcaseContent).HasMaxLength(63535).IsOptional();
            Property(x => x.DisplayShowcaseContent).IsRequired();
            Property(x => x.MetaKeywords).HasMaxLength(63535).IsOptional();
            Property(x => x.MetaDescription).HasMaxLength(63535).IsOptional();
            Property(x => x.PageTitle).HasMaxLength(255).IsOptional();
            Property(x => x.Attachment).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();





        }
    }
}
