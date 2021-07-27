using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class ExtraInfo:BaseEntity
    {
        //public ExtraInfo()
        //{
        //    ExtraInfoToProducts = new HashSet<ExtraInfoToProduct>();
        //}
        public string Name { get; set; }
        public int SortOrder { get; set; }
        //public ICollection<ExtraInfoToProduct> ExtraInfoToProducts { get; set; }
    }
}
