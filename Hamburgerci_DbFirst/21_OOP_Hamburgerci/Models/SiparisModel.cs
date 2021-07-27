using _21_OOP_Hamburgerci.Enums;
using _21_OOP_Hamburgerci.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_OOP_Hamburgerci.Helpers
{
    public class SiparisModel
    {
        public SiparisModel()
        {
            ExtraMalzemes = new HashSet<ExtraMalzeme>();
        }
        public int Id { get; set; }
        public Menuler Menu { get; set; }
        public int UrunAdeti { get; set; }
        public decimal ToplamTutar { get; set; }
        public Boyut Boyutu { get; set; }

        public ICollection<ExtraMalzeme> ExtraMalzemes { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += Menu.MenuFiyati;
            switch (Boyutu)
            {

                case Boyut.Normal:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Büyük:
                    ToplamTutar += ToplamTutar * 0.20M;
                    break;
            }
            foreach (ExtraMalzeme extra in ExtraMalzemes)
            {
                ToplamTutar += extra.EkstraMalzemeFiyati;
            }
            ToplamTutar = ToplamTutar * UrunAdeti;
        }

        public override string ToString()
        {
            if (ExtraMalzemes.Count < 1)
            {
                return string.Format("{0} Menü , X {1} Adet, {2} Boy, Toplam: {3} ", Menu.MenuAdi, UrunAdeti, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string extraMelzemeler = null;
                foreach (ExtraMalzeme item in ExtraMalzemes)
                {
                    extraMelzemeler += item.EkstraMalzemeAdi + ",";
                }
                extraMelzemeler = extraMelzemeler.Trim(',');


                return string.Format("{0} Menü , X {1} Adet, {2} Boy, Ex:{3} Toplam: {4} ", Menu.MenuAdi, UrunAdeti, Boyutu.ToString(), extraMelzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
