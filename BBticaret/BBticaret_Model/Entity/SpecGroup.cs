using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class SpecGroup:BaseEntity
    {
        //public SpecGroup()
        //{
        //    SpecNames = new HashSet<SpecName>();
        //    SpecValues = new HashSet<SpecValue>();
        //    SpecToProducts = new HashSet<SpecToProduct>();
        //}
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool Status { get; set; }
        //public ICollection<SpecName> SpecNames { get; set; }
        //public ICollection<SpecValue> SpecValues { get; set; }
        //public ICollection<SpecToProduct> SpecToProducts { get; set; }


    }
}
