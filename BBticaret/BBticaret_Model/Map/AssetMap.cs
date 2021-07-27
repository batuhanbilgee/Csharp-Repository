using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class AssetMap:BaseMap<Asset>
    {
        public AssetMap()
        {
            ToTable("dbo.Assets");
            Property(x => x.Key).IsOptional();
            Property(x => x.ContentType).IsOptional();
            Property(x => x.Attachment).IsOptional();
            Property(x => x.CreatedAt).HasColumnType("datetime2").IsOptional();
            Property(x => x.UpdatedAd).HasColumnType("datetime2").IsOptional();


        }
    }
}
