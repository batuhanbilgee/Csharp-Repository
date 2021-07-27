using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ExtraInfoMap:BaseMap<ExtraInfo>
    {
        public ExtraInfoMap()
        {
            ToTable("dbo.ExtraInfos");
            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(255);
            Property(x => x.SortOrder)
                .IsOptional();
                
        }
    }
}
