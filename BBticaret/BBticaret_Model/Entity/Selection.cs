using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class Selection:BaseEntity
    {
        //public Selection()
        //{
        //    SelectionToProducts = new HashSet<SelectionToProduct>();
        //}
       
        public string Title { get; set; }
        public int SortOrder { get; set; }
        [ForeignKey("SelectionGroup")]
        public int SelectionGroupId { get; set; }
        public SelectionGroup SelectionGroup { get; set; }

        //public ICollection<SelectionToProduct> SelectionToProducts { get; set; }

    }
}
