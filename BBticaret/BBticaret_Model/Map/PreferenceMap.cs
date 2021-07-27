using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class PreferenceMap:BaseMap<Preference>
    {
        public PreferenceMap()
        {
            ToTable("dbo.Preferences");
            Property(x => x.VarKey).HasMaxLength(255).IsOptional();
            Property(x => x.VarKey).IsOptional();
            
        }
    }
}
