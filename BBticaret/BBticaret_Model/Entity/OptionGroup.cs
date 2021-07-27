using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class OptionGroup:BaseEntity
    {
        //public OptionGroup()
        //{
        //    Options = new HashSet<Option>();
        //    OptionToProducts = new HashSet<OptionToProduct>();
        //}
        public string Title { get; set; }
        public string Slug { get; set; }
        public int SortOrder { get; set; }
        public bool FilterStatus { get; set; }
        //public ICollection<Option> Options { get; set; }
        //public ICollection<OptionToProduct> OptionToProducts { get; set; }
    }
}
