using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ShopUserlevelMap:BaseMap<ShopUserlevel>   
    {
        public ShopUserlevelMap()
        {
            ToTable("dbo.ShopUserlevels");
            Property(x => x.Label).IsOptional();
            Property(x => x.Roles).IsOptional();
        }
    }
}
