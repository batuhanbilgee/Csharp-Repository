using BBticaret_Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Map
{
    public class ScriptTagMap:BaseMap<ScriptTag>
    {
        public ScriptTagMap()
        {
            ToTable("dbo.ScriptTag");
            Property(x => x.Src).IsRequired();
        }
    }
}
