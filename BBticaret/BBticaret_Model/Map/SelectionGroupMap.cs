using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class SelectionGroupMap:BaseMap<SelectionGroup>
    {
        public SelectionGroupMap()
        {
            ToTable("dbo.SelectionGroups");
            Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(255);
            Property(x => x.SortOrder)
               .IsRequired();

        }
    }
}
