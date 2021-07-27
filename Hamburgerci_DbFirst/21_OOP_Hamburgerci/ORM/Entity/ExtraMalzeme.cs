using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Hamburgerci.ORM.Entity
{
    public class ExtraMalzeme:BaseEntity
    {
        public ExtraMalzeme()
        {
            SiparisToExtraMalzeme = new HashSet<SiparisToExtraMalzeme>();
        }
        public string EkstraMalzemeAdi { get; set; }
        public decimal EkstraMalzemeFiyati { get; set; }

        public ICollection<SiparisToExtraMalzeme> SiparisToExtraMalzeme { get; set; }
    }
}
