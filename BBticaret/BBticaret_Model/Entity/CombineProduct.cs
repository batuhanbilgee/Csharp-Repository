using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBticaret_Model.Entity
{
    public class CombineProduct:BaseEntity
    {
        //public CombineProduct()
        //{
        //    CombineProducts = new HashSet<CombineProduct>();
        //}
        
        public int CombineProductId { get; set; }
        public CombineProduct CProduct { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        //public ICollection<CombineProduct> CombineProducts { get; set; }
    }
}
