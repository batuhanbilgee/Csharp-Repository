using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Distributor:BaseEntity
    {
        //public Distributor()
        //{
        //    DistributorToProducts = new HashSet<DistributorToProduct>();
        //}
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContactPerson { get; set; }
        public int PreferanceId { get; set; }
        public Preference Preference { get; set; }
        //public ICollection<DistributorToProduct> DistributorToProducts { get; set; }
    }
}
