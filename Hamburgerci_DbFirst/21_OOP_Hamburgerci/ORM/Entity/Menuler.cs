using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Hamburgerci.ORM.Entity
{
    public class Menuler:BaseEntity
    {
        public Menuler()
        {
            Siparisler = new HashSet<Siparis>();
        }
        
        public string MenuAdi { get; set; }
        public decimal MenuFiyati { get; set; }
        public ICollection<Siparis> Siparisler { get; set; }

        public override string ToString()
        {
            return MenuAdi + " Menü";
        }

    }
}
