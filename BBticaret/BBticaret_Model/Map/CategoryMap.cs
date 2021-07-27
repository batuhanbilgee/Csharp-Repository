using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class CategoryMap:BaseMap<Category>
    {
        public CategoryMap()
        {
            ToTable("dbo.Categories");
            Property(x => x.Name).HasMaxLength(255).IsRequired();
            Property(x => x.Slug).HasMaxLength(255).IsOptional();
            Property(x => x.SortOrder).IsOptional();
            Property(x => x.Status).IsRequired();
            Property(x => x.DistributorCode).HasMaxLength(255).IsOptional();
            Property(x => x.Percent).IsOptional();
            Property(x => x.ImageFile).HasMaxLength(255).IsOptional();
            Property(x => x.Distributor).HasMaxLength(128).IsOptional();
            Property(x => x.DisplayShowcaseContent).IsRequired();
            Property(x => x.ShowcaseContent).HasMaxLength(63535).IsOptional();
            Property(x => x.ShowcaseContentDisplayType).IsRequired();
            Property(x => x.DisplayShowcaseFooterContent).IsRequired();
            Property(x => x.ShowCaseFooterContent).HasMaxLength(63535).IsOptional();
            Property(x => x.ShowcaseFooterContentDisplayType).IsRequired();
            Property(x => x.HasChildren).IsOptional();
            Property(x => x.MetaKeywords).HasMaxLength(63535).IsOptional();
            Property(x => x.MetaDescription).HasMaxLength(63535).IsOptional();
            Property(x => x.PageTitle).HasMaxLength(63535).IsOptional();
            Property(x => x.CategoryId).IsOptional();
            Property(x => x.Attachment).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAt).HasColumnType("datetime2").IsOptional();













        }
    }
}
