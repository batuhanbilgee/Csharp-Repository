using _21_OOP_Hamburgerci.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Hamburgerci.ORM.Entity
{
    public class Siparis : BaseEntity
    {
        public Siparis()
        {
            SiparisToExtraMalzeme = new HashSet<SiparisToExtraMalzeme>();
        }

       
       
        public Boyut Boyutu { get; set; }
        public int UrunAdeti { get; set; }
        public decimal ToplamTutar { get; set; }
        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public Menuler Menu { get; set; }

        public ICollection<SiparisToExtraMalzeme> SiparisToExtraMalzeme { get; set; }


      
    }
}
