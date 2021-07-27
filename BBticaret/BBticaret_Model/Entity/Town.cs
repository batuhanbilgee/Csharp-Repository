using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Town:BaseEntity
    {
        //public Town()
        //{
        //    MemberAddresses = new HashSet<MemberAddress>();
        //}
        public string Name { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Location")]
        public int LocationId { get; set; }
        public Location Location { get; set; }
        [ForeignKey("TownGroup")]
        public int TownGroupId { get; set; }
        public TownGroup TownGroup { get; set; }
        //public ICollection<MemberAddress> MemberAddresses { get; set; }
    }
}
