using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class SelectionGroup:BaseEntity
    {
        //public SelectionGroup()
        //{
        //    Selections = new HashSet<Selection>();
        //}
        public string Title { get; set; }
        public int SortOrder { get; set; }
        //public ICollection<Selection> Selections { get; set; }


    }
}
