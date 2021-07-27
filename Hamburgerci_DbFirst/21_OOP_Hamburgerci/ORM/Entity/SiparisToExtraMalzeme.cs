using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Hamburgerci.ORM.Entity
{
    public class SiparisToExtraMalzeme :BaseEntity
    {
        [ForeignKey("Siparis")]
        public int SiparisId { get; set; }
        public Siparis Siparis { get; set; }
        [ForeignKey("ExtraMalzeme")]
        public int ExtraMalzemeId { get; set; }
        public ExtraMalzeme ExtraMalzeme { get; set; }
    }
}
