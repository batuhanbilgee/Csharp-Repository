using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class TownGroup:BaseEntity
    {
        //public TownGroup()
        //{
        //    Towns = new HashSet<Town>();
        //}
        public string Name { get; set; }
        public bool Status { get; set; }
        //public ICollection<Town> Towns { get; set; }
    }
}
