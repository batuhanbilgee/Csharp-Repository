using BBticaret_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Country:BaseEntity
    {
        //public Country()
        //{
        //    Regions = new HashSet<Region>();
        //    Locations = new HashSet<Location>();
        //    Members = new HashSet<Member>();
        //    MemberAddresses = new HashSet<MemberAddress>();
        //    PreOrderInfos = new HashSet<PreOrderInfo>();
        //    PreOrderInfos = new HashSet<PreOrderInfo>();
        //}

        public string Name { get; set; }
        public string Code { get; set; }
        public CountryStatus Status { get; set; }
        //public ICollection<Region> Regions { get; set; }
        //public ICollection<Location> Locations { get; set; }
        //public ICollection<Member> Members { get; set; }
        //public ICollection<MemberAddress> MemberAddresses { get; set; }
        //public ICollection<PreOrderInfo> PreOrderInfos { get; set; }



    }
}
